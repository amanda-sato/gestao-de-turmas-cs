using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class TurmasForm : Form
    {
        public TurmasForm()
        {
            InitializeComponent();
            init();
            carregaEntidade();
            resetaForm();
        }

        public void init()
        {
            Text = $"Menu {getNomeEntidade()}";

            labelID.Text = "ID";
            labelNome.Text = $"Nome {getNomeEntidade()}";
            labelList.Text = $"{getNomeEntidadePlural()} Disponiveis";

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Text = $"Remover {getNomeEntidade()}";
        }

        public string getNomeEntidade() => "Turma";

        public string getNomeEntidadePlural() => "Turmas";

        protected void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
        protected void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        protected void buttonLimpar_Click(object sender, EventArgs e) => resetaForm();

        protected void carregaEntidade()
        {
            foreach (Turma t in Program.GetState().turmas)
            {
                listBox.Items.Add(t);
            }
        }

        protected void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                salvar(sender, e);
                return;
            }

            editar(sender, e);
        }

        protected void salvar(object sender, EventArgs e)
        {
            try
            {
                Turma novaTurma = new Turma();

                string nomeTurma = textBoxNome.Text;
                int id = int.Parse(textBoxId.Text);
                
                novaTurma.setId(id);
                novaTurma.setNomeTurma(nomeTurma);

                Program.GetState().turmas.Add(novaTurma);
                listBox.Items.Add(novaTurma);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void listTurmas_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            new AlunosTurmaForm(listBox.SelectedItem as Turma).ShowDialog();
        }

        protected void listBox_SingleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            modoEdicao();

            Turma selectedTurmas = listBox.SelectedItem as Turma;

            textBoxNome.Text = selectedTurmas.getNomeTurma();
            textBoxId.Text = selectedTurmas.getId().ToString();
        }

        protected void editar(object sender, EventArgs e)
        {
            Turma selectedTurma = listBox.SelectedItem as Turma;

            selectedTurma.setNomeTurma(textBoxNome.Text);
            Program.GetState().turmas.Atualizar(selectedTurma);

            listBox.Items[listBox.SelectedIndex] = selectedTurma;

            resetaForm();
        }

        protected void buttonRemover_Click(object sender, EventArgs e)
        {
            Turma selectedTurmas = listBox.SelectedItem as Turma;

            Program.GetState().turmas.Remove(selectedTurmas);

            listBox.Items.Remove(selectedTurmas);

            resetaForm();
        }

        protected void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }

        protected void resetaForm()
        {
            textBoxId.Text = Turma.getNextId().ToString();
            textBoxNome.Clear();

            listBox.ClearSelected();

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonRemover.Enabled = false;
        }

        private void taxaDeAprovaçãoPorDisciplinaToolStripMenuItem_Click(object sender, EventArgs e) => new TaxaAprovacaoDisciplinas().ShowDialog();

        private void médiaGeralPorAlunoToolStripMenuItem_Click(object sender, EventArgs e) => new MediaGeralPorAluno().ShowDialog();
    }
}
