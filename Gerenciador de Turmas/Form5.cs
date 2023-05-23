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
    public partial class Form5 : Form
    {
        public static Form5 instance;
        public Form5()
        {
            InitializeComponent();
            instance = this;
        }

        private void voltarAoMenuTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4.instance.Focus();
            this.Close();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
