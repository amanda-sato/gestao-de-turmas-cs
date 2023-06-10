using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Turmas
{
    public class NotaRepo : Repo<Nota>
    {
        public bool ExistePara(Disciplina disciplina, Aluno aluno)
        {
            int index = _list.FindIndex(n => n.getDisciplinaId() == disciplina.getId() && n.getAlunoId() == aluno.getId());

            return index >= 0;
        }

        public double NotaAlunoEm(Disciplina disciplina, Aluno aluno)
        {
            int index = _list.FindIndex(n => n.getDisciplinaId() == disciplina.getId() && n.getAlunoId() == aluno.getId());

            if (index >= 0)
            {
                return _list[index].getNota();
            }

            return -1;
        }

        public List<NotaGrid> ToBindingSourceList(int alunoId)
        {
            DisciplinaRepo disciplinas = Program.GetState().disciplinas;
            AlunoRepo alunos = Program.GetState().alunos;

            HashSet<int> disciplinasComNotaDoAluno = new HashSet<int>();
            List<NotaGrid> notas = new List<NotaGrid>();

            foreach (Nota n in _list)
            {
                if (n.getAlunoId() == alunoId)
                {
                    if (! disciplinasComNotaDoAluno.Contains(n.getDisciplinaId()))
                    {
                        disciplinasComNotaDoAluno.Add(n.getDisciplinaId());
                    }

                    notas.Add(n);
                }
            }

            notas.Sort();

            return notas;
        }
    }
}
