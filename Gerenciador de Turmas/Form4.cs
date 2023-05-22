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
    
    public partial class Form4 : Form
    {
        public static Form4 instance;
        public Form4()
        {
            InitializeComponent();
            instance = this;
        }

        private void voltarAoMenuTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2.instance.Focus();
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
                Aluno aluno1 = new Aluno();

                int matricula = int.Parse(textBox1.Text);
                string nomeAluno = textBox2.Text;
                string genero = textBox3.Text;

                aluno1.setMatricula(matricula);
                aluno1.setNomeAluno(nomeAluno);
                aluno1.setGenero(genero);

                listAlunos.Items.Add(aluno1);
    }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
