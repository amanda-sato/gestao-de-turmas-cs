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
    public partial class RelacaoAlunosAprovadosReprovados : Form
    {
        public RelacaoAlunosAprovadosReprovados()
        {
            InitializeComponent();

            dataGridView.ColumnCount = 4;
            dataGridView.ColumnHeadersVisible = true;

            dataGridView.Columns[0].Name = "Disciplina";
            dataGridView.Columns[1].Name = "Turma";
            dataGridView.Columns[2].Name = "Aluno";
            dataGridView.Columns[3].Name = "Situacao";

            carregaInfos();
        }

        private void carregaInfos()
        {
            foreach (Disciplina disciplina in Program.GetState().disciplinas)
            {
                foreach (Turma turma in Program.GetState().turmas)
                {
                    foreach (Aluno aluno in Program.GetState().alunos)
                    {
                        if (aluno.getTurmaId() == turma.getId())
                        {
                            dataGridView.Rows.Add(new string[] { disciplina.getNomeDisc(), turma.getNomeTurma(), aluno.getNomeAluno(), aluno.situacao(disciplina) });
                        }
                    }
                }
            }
        }

        protected void voltarAoMenuDeTurmaslToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        protected void encerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}
