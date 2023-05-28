using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class AlunosTurmaForm : Form
    {
        public static AlunosTurmaForm instance;
        private Turma turma;

        public AlunosTurmaForm(Turma turma)
        {
            InitializeComponent();
            instance = this;

            this.turma = turma;

            textBoxIdTurma.Text = this.turma.getId().ToString();
            textBoxTurma.Text = this.turma.getNomeTurma();

            foreach (Aluno t in Program.GetState().alunos)
            {
                if (t.getTurmaId() == this.turma.getId())
                {
                    listBox.Items.Add(t);
                }
            }

            resetaForm();
        }

        public string getNomeEntidade()
        {
            return "Aluno";
        }

        public string getNomeEntidadePlural()
        {
            return "Alunos";
        }


        private void voltarAoMenuTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurmasForm.instance.Focus();
            this.Close();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                adicionar(sender, e);
                return;
            }

            editar(sender, e);
        }

        private void adicionar(object sender, EventArgs e)
        {
            try
            {
                Aluno novoAluno = new Aluno();

                novoAluno
                    .setTurmaId(turma.getId())
                    .setMatricula(int.Parse(textBoxId.Text))
                    .setNomeAluno(textBoxNome.Text)
                    .setGenero(textBoxGenero.Text);

                Program.GetState().alunos.Add(novoAluno);
                listBox.Items.Add(novoAluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editar(object sender, EventArgs e) 
        { 
            Aluno aluno = listBox.SelectedItem as Aluno;

            aluno
                .setNomeAluno(textBoxNome.Text)
                .setGenero(textBoxGenero.Text);

            Program.GetState().alunos.Atualizar(aluno);
            listBox.Items[listBox.SelectedIndex] = aluno;

            resetaForm();
        }

        private void listAlunos_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            new NotasAlunoForm(listBox.SelectedItem as Aluno).Show();
        }

        private void listAlunos_singleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            Aluno aluno = listBox.SelectedItem as Aluno;

            textBoxId.Text = aluno.getMatricula().ToString();
            textBoxGenero.Text = aluno.getGenero();
            textBoxNome.Text = aluno.getNomeAluno();

            modoEdicao();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma disciplina!");
                return;
            }

            Aluno aluno = listBox.SelectedItem as Aluno;

            Program.GetState().alunos.Remove(aluno);
            listBox.Items.Remove(aluno);

            resetaForm();
        }

        protected void buttonLimpar_Click(object sender, EventArgs e)
        {
            resetaForm();
        }

        private void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }

        private void resetaForm()
        {
            textBoxId.Text = Aluno.getNextId().ToString();

            textBoxNome.Clear();
            textBoxGenero.Clear();
            listBox.ClearSelected();

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Enabled = false;
        }
    }
}
