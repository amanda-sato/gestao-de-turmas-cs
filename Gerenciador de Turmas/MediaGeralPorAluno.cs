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
    public partial class MediaGeralPorAluno : Form
    {
        public MediaGeralPorAluno()
        {
            InitializeComponent();

            dataGridView.ColumnCount = 2;
            dataGridView.ColumnHeadersVisible = true;
            dataGridView.Columns[0].Name = "Aluno(a)";
            dataGridView.Columns[1].Name = "Media Geral";

            carregaInfos();
        }

        private void carregaInfos()
        {
            foreach (Aluno a in Program.GetState().alunos)
            {
                double total = 0;
                int notasCont = 0;

                foreach (Nota n in Program.GetState().notas)
                {
                    if (a.getId() == n.getAlunoId())
                    {
                        total += n.getNota();
                        notasCont++;
                    }

                }

                string valor = notasCont > 0 
                    ? String.Format("{0:0.00}", total / notasCont) 
                    : "--";

                dataGridView.Rows.Add(new string[] { a.getNomeAluno(), valor });
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }
    }
}
