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
        public State state;

        public MainForm(State nState)
        {
            InitializeComponent();
            instance = this;

            state = nState;
        }

        private void buttonTurmas_Click(object sender, EventArgs e)
        {
            if (TurmasForm.instance == null)
            {
                TurmasForm form = new TurmasForm();
                form.Show();

                return;
            }

            TurmasForm.instance.Focus();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDisciplinas_Click(object sender, EventArgs e)
        {
            if (DisciplinasForm.instance == null)
            {
                DisciplinasForm form = new DisciplinasForm();
                form.Show();

                return;
            }

            DisciplinasForm.instance.Focus();
        }
    }
}
