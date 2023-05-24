using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public partial class TurmasForm : Form
    {
        public static TurmasForm instance;
        public TurmasForm()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.instance.Focus();
            this.Close();

        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Turma turma1 = new Turma();

                string nomeTurma = textBox1.Text;
                double id = double.Parse(textBox2.Text);
                
                turma1.setId(id);
                turma1.setNomeTurma(nomeTurma);

                listTurmas.Items.Add(turma1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listTurmas_DoubleClick(object sender, EventArgs e)
        {
            if (listTurmas.SelectedItems !=  null)
            {
                AlunosTurmaForm form = new AlunosTurmaForm();
                form.Show();

                if (listTurmas.SelectedItem != null)
                {
                    Turma selectedDisciplina = listTurmas.SelectedItem as Turma;

                    AlunosTurmaForm.instance.textBox4.Text = selectedDisciplina.getId().ToString();
                    AlunosTurmaForm.instance.textBox5.Text = selectedDisciplina.getNomeTurma();

                }


            }

        }

        private void listTurmas_singleClick(object sender, EventArgs e)
        {
            if (listTurmas.SelectedItem != null)
            {
                Turma selectedDisciplina = listTurmas.SelectedItem as Turma;

                textBox2.Text = selectedDisciplina.getId().ToString();
                textBox1.Text = selectedDisciplina.getNomeTurma();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listTurmas.SelectedItem != null)
            {
                Turma selectedTurmas = listTurmas.SelectedItem as Turma;

                listTurmas.Items.Remove(selectedTurmas);
            }
            else
            {
                MessageBox.Show("Selecione uma Turma!");
            }
        }

        private void listTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
