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
        public State state;

        public MainForm(State nState)
        {
            InitializeComponent();
            state = nState;
        }

        private void buttonTurmas_Click(object sender, EventArgs e) => new TurmasForm().ShowDialog();

        private void buttonDisciplinas_Click(object sender, EventArgs e) => new DisciplinasForm().ShowDialog();

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Deseja salvar as alterações?", "Oi!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            state.salva();
        }
    }
}
