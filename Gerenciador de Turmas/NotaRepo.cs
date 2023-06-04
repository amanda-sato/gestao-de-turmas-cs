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
        public BindingSource ToBindingSource(int alunoId)
        {
            DisciplinaRepo disciplinas = Program.GetState().disciplinas;
            AlunoRepo alunos = Program.GetState().alunos;

            HashSet<int> disciplinasComNotaDoAluno = new HashSet<int>();
            List<NotaGrid> notas = new List<NotaGrid>();

            string nomeAluno = alunos.GetPorId(alunoId).getNomeAluno();

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

            foreach (Disciplina d in disciplinas)
            {
                if (! disciplinasComNotaDoAluno.Contains(d.getId()))
                {
                    notas.Add(new NotaGrid(
                        id: -1,
                        alunoId: alunoId,
                        nomeAluno: nomeAluno,
                        disciplinaId: d.getId(),
                        nomesDisc: disciplinas.GetPorId(d.getId()).getNomeDisc(),
                        nota: -1
                    ));
                }
            }

            notas.Sort();

            BindingSource list = new BindingSource();
            list.DataSource = notas;

            return list;
        }
    }
}
