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
            MessageBox.Show("Oi!");
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
                //adicionar disciplina, verificar se é Disciplinas ou Disciplina.
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
