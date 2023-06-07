using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class NotasAlunoForm : Form
    {
        private Aluno aluno;
        private BindingSource bindingSource;
        private List<NotaGrid> notasGrid;

        public NotasAlunoForm(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private string getNomeEntidade() => "Nota";

        private void carregaEntidades(object sender, EventArgs e)
        {
            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                listBoxDisc.Items.Add(d);
            }

            carregaComboBoxDisciplina();

            textBoxIdAluno.Text = aluno.getMatricula().ToString();
            textBoxNomeAluno.Text = aluno.getNomeAluno();

            notasGrid = Program.GetState().notas.ToBindingSourceList(aluno.getId());

            bindingSource = new BindingSource();
            bindingSource.DataSource = notasGrid;
            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["alunoId"].Visible = false;
            dataGridView.Columns["disciplinaId"].Visible = false;
            dataGridView.Columns["nomeAluno"].Visible = false;
            dataGridView.Columns["id"].Visible = false;

            resetaForm();
        }

        private void carregaComboBoxDisciplina()
        {
            comboBoxDisciplina.Items.Clear();

            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                if (!Program.GetState().notas.ExistePara(d, aluno))
                {
                    comboBoxDisciplina.Items.Add(d);
                }
            }
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

            editar(sender, e);
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
                notasGrid.Add((NotaGrid)nota);
                notasGrid.Sort();

                bindingSource.ResetBindings(false);

                if (comboBoxDisciplina.Items.Count <= 0)
                {
                    comboBoxDisciplina.Enabled = false;
                }

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editar(object sender, EventArgs e)
        {
            try
            {
                NotaGrid notaGrid = (NotaGrid)dataGridView.SelectedRows[0].DataBoundItem;

                notaGrid.nota = double.Parse(textBoxNota.Text);

                Program.GetState().notas.Atualizar(notaGrid);
                bindingSource.ResetBindings(false);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetaForm()
        {
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;

            buttonSalvar.Text = $"Adicionar {getNomeEntidade()}";
            buttonSalvar.Enabled = false;

            carregaComboBoxDisciplina();

            comboBoxDisciplina.Enabled = comboBoxDisciplina.Items.Count > 0;
            comboBoxDisciplina.SelectedItem = null;
            comboBoxDisciplina.Text = "--Selecione--";

            textBoxNota.Clear();
            textBoxNota.Enabled = comboBoxDisciplina.Items.Count > 0;
        }

        protected void modoEdicao()
        {
            comboBoxDisciplina.Enabled = false;
            buttonRemover.Enabled = true;
            buttonSalvar.Text = $"Editar {getNomeEntidade()}";
        }

        private void comboBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = comboBoxDisciplina.SelectedItem != null;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            NotaGrid notaGrid = (NotaGrid)dataGridView.SelectedRows[0].DataBoundItem;

            Program.GetState().notas.Remove(notaGrid);
            notasGrid.Remove(notaGrid);
            bindingSource.ResetBindings(false);

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
            textBoxNota.Text = notaGrid.nota.ToString();

            Disciplina disciplina = Program.GetState().disciplinas.GetPorId(notaGrid.disciplinaId);
            comboBoxDisciplina.Items.Add(disciplina);
            comboBoxDisciplina.SelectedItem = disciplina;
        }
    }
}
