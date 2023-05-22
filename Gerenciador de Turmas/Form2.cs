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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltarAoMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.instance.Focus();
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
                int quantidade = int.Parse(textBox3.Text);

                turma1.setId(id);
                turma1.setNomeDisc(nomeTurma);
                turma1.setQuantidade(quantidade);

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
                Form4 form = new Form4();
                form.Show();
            }

        }
    }
}
