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
        public BindingSource ToBindingSource(DisciplinaRepo disciplinas, AlunoRepo alunos, int alunoId, int maxNotas = 3)
        {
            List<NotaGrid> notas = new List<NotaGrid>();

            foreach (Nota n in _list)
            {
                if (n.getAlunoId() == alunoId)
                {
                    notas.Add(new NotaGrid(
                        id: n.getId(),
                        alunoId: n.getAlunoId(),
                        nomeAluno: alunos.GetPorId(n.getAlunoId()).getNomeAluno(),
                        disciplinaId: n.getDisciplinaId(),
                        nomesDisc: disciplinas.GetPorId(n.getDisciplinaId()).getNomeDisc(),
                        nota: n.getNota()
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
