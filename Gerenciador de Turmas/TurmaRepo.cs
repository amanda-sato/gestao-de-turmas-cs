using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class TurmaRepo : Repo<Turma>
    {
        public new void Add(Turma item)
        {
            int index = _list.FindIndex(t => Utils.normaliza(t.getNomeTurma()) == Utils.normaliza(item.getNomeTurma()));

            if (index >= 0)
            {
                Turma t = _list[index];
                throw new ArgumentException($"Uma turma de mesmo nome {item.getNomeTurma()} ja esta cadastrada ({t.getNomeTurma()}).");
            }

            base.Add(item);
        }
    }
}
