using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class NotasAlunoForm : Form
    {
        private Aluno aluno;
        private BindingSource bindingSource;

        public NotasAlunoForm(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;

            textBoxIdAluno.Text = aluno.getMatricula().ToString();
            textBoxNomeAluno.Text = aluno.getNomeAluno();

            bindingSource = Program.GetState().notas.ToBindingSource(aluno.getId());
        }

        private string getNomeEntidade() => "Nota";

        private void carregaEntidades(object sender, EventArgs e)
        {
            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                comboBoxDisciplina.Items.Add(d);
            }

            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["alunoId"].Visible = false;
            dataGridView.Columns["disciplinaId"].Visible = false;
            dataGridView.Columns["nomeAluno"].Visible = false;

            resetaForm();
        }

        private void voltarAoMenuTurmaToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void buttonLimpar_Click(object sender, EventArgs e) => resetaForm();

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0)
            {
                adicionar(sender, e);
                return;
            }
            //editar(sender, e);
        }

        private void adicionar(object sender, EventArgs e)
        {
            try
            {
                Nota nota = new Nota();

                int alunoId = int.Parse(textBoxIdAluno.Text);
                Disciplina disciplina = comboBoxDisciplina.SelectedItem as Disciplina;
                double valorNota = double.Parse(textBoxNota.Text);

                nota.setAlunoId(alunoId);
                nota.setDisciplinaId(disciplina.getId());
                nota.setNota(valorNota);

                Program.GetState().notas.Add(nota);

                bindingSource.Add((NotaGrid)nota);

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
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;

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

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0) return;

            modoEdicao();

            NotaGrid notaGrid = (NotaGrid)dataGridView.SelectedRows[0].DataBoundItem;

            comboBoxDisciplina.SelectedItem = Program.GetState().disciplinas.GetPorId(notaGrid.disciplinaId);
            textBoxNota.Text = notaGrid.nota.ToString();
        }
    }
}
