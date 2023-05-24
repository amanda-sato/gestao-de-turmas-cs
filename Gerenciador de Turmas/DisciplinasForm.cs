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
                listDisciplinas.Items.Add(d);
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

        private void buttonAddDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina novaDisciplina = new Disciplina();

                int id = int.Parse(textBoxIdDisciplina.Text);
                string nomeDisc = textBoxNomeDaDisciplina.Text;

                novaDisciplina.setId(id);
                novaDisciplina.setNomeDisc(nomeDisc);

                MainForm.instance.state.disciplinas.Add(novaDisciplina);
                listDisciplinas.Items.Add(novaDisciplina);

                resetaForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void listAlunos_singleClick(object sender, EventArgs e)
        {
            if (listDisciplinas.SelectedItem != null)
            {
                Disciplina selectedDisciplina = listDisciplinas.SelectedItem as Disciplina;

                textBoxIdDisciplina.Text = selectedDisciplina.getId().ToString();
                textBoxNomeDaDisciplina.Text = selectedDisciplina.getNomeDisc();   
            }
        }

        private void buttonRemoverDisciplina_Click(object sender, EventArgs e)
        {
            if (listDisciplinas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma disciplina!");
                return;
            }
            
            Disciplina selectedDisciplina = listDisciplinas.SelectedItem as Disciplina;

            MainForm.instance.state.disciplinas.Remove(selectedDisciplina);
            listDisciplinas.Items.Remove(selectedDisciplina);

            resetaForm();
        }

        private void buttonEditarDisciplina_Click(object sender, EventArgs e)
        {
            if (listDisciplinas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma disciplina!");
                return;
            }

            Disciplina selectedDisciplina = listDisciplinas.SelectedItem as Disciplina;

            selectedDisciplina.setNomeDisc(textBoxNomeDaDisciplina.Text);
            MainForm.instance.state.disciplinas.Atualizar(selectedDisciplina);

            listDisciplinas.Items[listDisciplinas.SelectedIndex] = selectedDisciplina;

            resetaForm();
        }

        private void resetaForm()
        {
            textBoxIdDisciplina.Text = Disciplina.getNextId().ToString();
            textBoxNomeDaDisciplina.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetaForm();
        }
    }
}
