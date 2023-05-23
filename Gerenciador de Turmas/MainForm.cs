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
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurmasForm form = new TurmasForm();
            form.Show();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisciplinasForm form = new DisciplinasForm();
            form.Show();
        }
    }
}
