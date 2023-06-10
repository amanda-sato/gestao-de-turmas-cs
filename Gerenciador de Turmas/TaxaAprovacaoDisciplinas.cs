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

            dataGridView.ColumnCount = 2;
            dataGridView.ColumnHeadersVisible = true;
            dataGridView.Columns[0].Name = "Disciplina";
            dataGridView.Columns[1].Name = "Taxa de aprovação (%)";

            carregaInfos();
        }

        private void carregaInfos()
        {
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

                if (totalNotasDisciplina > 0)
                {
                    dataGridView.Rows.Add(new string[]{ d.getNomeDisc(), String.Format("{0:0.00}", totalAprovados / totalNotasDisciplina * 100)})  ;
                }
                else
                {
                    dataGridView.Rows.Add(new string[]{ d.getNomeDisc(), "--" });
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }
    }
}
