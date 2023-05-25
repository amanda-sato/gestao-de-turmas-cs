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

            foreach (Turma t in MainForm.instance.state.turmas)
            {
                listTurmas.Items.Add(t);
            }

            resetaForm();
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
                int id = int.Parse(textBox2.Text);
                
                turma1.setId(id);
                turma1.setNomeTurma(nomeTurma);

                MainForm.instance.state.turmas.Add(turma1);
                listTurmas.Items.Add(turma1);

                resetaForm();

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
                Turma selectedTurmas = listTurmas.SelectedItem as Turma;

                textBox2.Text = selectedTurmas.getId().ToString();
                textBox1.Text = selectedTurmas.getNomeTurma();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listTurmas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma Turma!");
                return;

            }   
            
            Turma selectedTurmas = listTurmas.SelectedItem as Turma;

            MainForm.instance.state.turmas.Remove(selectedTurmas);

            listTurmas.Items.Remove(selectedTurmas);

            resetaForm();
        }


        private void resetaForm()
        {
            textBox2.Text = Turma.getNextId().ToString();
            textBox1.Clear();
        }

        private void listTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetaForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listTurmas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma Turma!");
                return;
            }

            Turma selectedTurma = listTurmas.SelectedItem as Turma;

            selectedTurma.setNomeTurma(textBox1.Text);
            MainForm.instance.state.turmas.Atualizar(selectedTurma);

            listTurmas.Items[listTurmas.SelectedIndex] = selectedTurma;

            resetaForm();
        }
    }
}
