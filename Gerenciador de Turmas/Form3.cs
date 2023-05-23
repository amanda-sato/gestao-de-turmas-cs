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
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.instance.Focus();
            this.Close();
        }

        private void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Disciplina disciplina1 = new Disciplina();

                double id = int.Parse(textBox1.Text);
                string nomeDisc = textBox2.Text;

                disciplina1.setId(id);
                disciplina1.setNomeDisc(nomeDisc);               

                listDisciplinas.Items.Add(disciplina1);
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

                textBox1.Text = selectedDisciplina.getId().ToString();
                textBox2.Text = selectedDisciplina.getNomeDisc();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listDisciplinas.SelectedItem != null)
            {
                Disciplina selectedDisciplina = listDisciplinas.SelectedItem as Disciplina;

                listDisciplinas.Items.Remove(selectedDisciplina);
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina!");
            }
        }
    }
}
