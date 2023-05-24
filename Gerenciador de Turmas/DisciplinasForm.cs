using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }

        private void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.instance.Focus();
            this.Close();
        }

        private void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            if (listDisciplinas.SelectedItem != null)
            {
                Disciplina selectedDisciplina = listDisciplinas.SelectedItem as Disciplina;

                MainForm.instance.state.disciplinas.Remove(selectedDisciplina);
                listDisciplinas.Items.Remove(selectedDisciplina);
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina!");
            }
        }
    }
}
