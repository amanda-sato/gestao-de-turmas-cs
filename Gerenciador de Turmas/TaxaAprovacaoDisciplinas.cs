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
    public partial class TaxaAprovacaoDisciplinas : Form
    {
        public TaxaAprovacaoDisciplinas()
        {
            InitializeComponent();

            dataGridView.ColumnCount = 3;
            dataGridView.ColumnHeadersVisible = true;
            dataGridView.Columns[0].Name = "Disciplina";
            dataGridView.Columns[1].Name = "Taxa de aprovação (%)";
            dataGridView.Columns[2].Name = "Alunos com nota";

            carregaInfos();
        }

        private void carregaInfos()
        {
            int totalAlunos = Program.GetState().alunos.Count();

            foreach (Disciplina d in Program.GetState().disciplinas)
            {
                int totalAprovados = 0;
                int totalNotasDisciplina = 0;

                foreach (Nota n in Program.GetState().notas)
                {
                    if (d.getId() == n.getDisciplinaId() && n.getNota() >= 10)
                    {
                        totalAprovados++;
                    }

                    if (d.getId() == n.getDisciplinaId())
                    {
                        totalNotasDisciplina++;
                    }
                }

                string valor = totalNotasDisciplina > 0
                    ? String.Format("{0:0.00}", (double)(totalAprovados) / totalNotasDisciplina * 100)
                    : "--";

                dataGridView.Rows.Add(new string[] { d.getNomeDisc(), valor, $"{totalNotasDisciplina}/{totalAlunos}" });
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }

        protected void voltarAoMenuDeTurmaslToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        protected void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}
