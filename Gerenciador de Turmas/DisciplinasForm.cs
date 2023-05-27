using System;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class DisciplinasForm : Form
    {
        public static DisciplinasForm instance;

        public DisciplinasForm()
        {
            InitializeComponent();
            instance = this;

            foreach (Disciplina d in MainForm.instance.state.disciplinas)
            {
                listBox.Items.Add(d);
            }

            resetaForm();
        }

        private void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.instance.Focus();
            this.Close();
        }

        private void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                salvar(sender, e);
                return;
            }

            editar(sender, e);
        }

        private void salvar(Object sender, EventArgs e)
        {
            try
            {
                Disciplina novaDisciplina = new Disciplina();

                int id = int.Parse(textBoxIdDisciplina.Text);
                string nomeDisc = textBoxNomeDaDisciplina.Text;

                novaDisciplina.setId(id);
                novaDisciplina.setNomeDisc(nomeDisc);

                MainForm.instance.state.disciplinas.Add(novaDisciplina);
                listBox.Items.Add(novaDisciplina);

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
                Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

                selectedDisciplina.setNomeDisc(textBoxNomeDaDisciplina.Text);
                MainForm.instance.state.disciplinas.Atualizar(selectedDisciplina);

                listBox.Items[listBox.SelectedIndex] = selectedDisciplina;

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_SingleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            modoEdicao();

            Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

            textBoxIdDisciplina.Text = selectedDisciplina.getId().ToString();
            textBoxNomeDaDisciplina.Text = selectedDisciplina.getNomeDisc();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma disciplina!");
                return;
            }
            
            Disciplina selectedDisciplina = listBox.SelectedItem as Disciplina;

            MainForm.instance.state.disciplinas.Remove(selectedDisciplina);
            listBox.Items.Remove(selectedDisciplina);

            resetaForm();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            resetaForm();
        }

        private void resetaForm()
        {
            textBoxIdDisciplina.Text = Disciplina.getNextId().ToString();
            textBoxNomeDaDisciplina.Clear();

            listBox.ClearSelected();

            buttonSalvar.Text = "Adicionar Disciplina";
            buttonRemover.Enabled = false;
        }

        private void modoEdicao()
        {
            buttonRemover.Enabled = true;
            buttonSalvar.Text = "Editar Disciplina";
        }
    }
}
