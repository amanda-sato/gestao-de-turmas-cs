using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class NotasAlunoForm : Form
    {
        private Aluno aluno;

        public NotasAlunoForm(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;

            textBoxIdAluno.Text = aluno.getMatricula().ToString();
            textBoxNomeAluno.Text = aluno.getNomeAluno();
        }

        private string getNomeEntidade() => "Nota";

        private void carregaEntidades(object sender, EventArgs e)
        {
            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                comboBoxDisciplina.Items.Add(d);
            }

            dataGridView.AutoGenerateColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.DataSource = Program.GetState().notas.ToBindingSource(
                alunoId: aluno.getId(),
                disciplinas: Program.GetState().disciplinas,
                alunos: Program.GetState().alunos
            );

            dataGridView.Columns["alunoId"].Visible = false;
            dataGridView.Columns["disciplinaId"].Visible = false;
            dataGridView.Columns["nomeAluno"].Visible = false;

            resetaForm();
        }

        private void voltarAoMenuTurmaToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void buttonLimpar_Click(object sender, EventArgs e) => resetaForm();

        //private void listBox_singleClick(object sender, EventArgs e)
        //{
        //    if (listBox.SelectedItem == null) return;

        //    modoEdicao();

        //    Nota nota = listBox.SelectedItem as Nota;

        //    comboBoxDisciplina.SelectedItem = Program.GetState().disciplinas.GetPorId(nota.getDisciplinaId());
        //    textBoxNota.Text = nota.getNota().ToString();
        //}

        //private void buttonSalvar_Click(object sender, EventArgs e)
        //{
        //    if (listBox.SelectedItem == null)
        //    {
        //        adicionar(sender, e);
        //        return;
        //    }

        //    editar(sender, e);
        //}

        private void adicionar(object sender, EventArgs e)
        {
            try
            {
                Nota nota = new Nota();

                int alunoId = int.Parse(textBoxIdAluno.Text);
                int disciplinaId = (comboBoxDisciplina.SelectedItem as Disciplina).getId();
                double valorNota = double.Parse(textBoxNota.Text);

                nota.setAlunoId(alunoId);
                nota.setDisciplinaId(disciplinaId);
                nota.setNota(valorNota);

                Program.GetState().notas.Add(nota);
                dataGridView.Rows.Add(nota);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void editar(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Nota nota = listBox.SelectedItem as Nota;

        //        nota.setNota(double.Parse(textBoxNota.Text));

        //        Program.GetState().notas.Atualizar(nota);
        //        listBox.Items[listBox.SelectedIndex] = nota;

        //        resetaForm();
        //    } 
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void resetaForm()
        {
            //listBox.ClearSelected();

            comboBoxDisciplina.SelectedItem = null;
            comboBoxDisciplina.SelectedText = "--Selecione--";

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonSalvar.Enabled = false;
            textBoxNota.Clear();
        }

        protected void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }

        private void comboBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = comboBoxDisciplina.SelectedItem != null;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            //Nota nota = listBox.SelectedItem as Nota;

            //Program.GetState().notas.Remove(nota);
            //listBox.Items.Remove(nota);

            resetaForm();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != "-1") return;

            e.Value = "--";
            e.FormattingApplied = true;
        }
    }
}
