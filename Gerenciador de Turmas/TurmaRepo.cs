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
            FalhaSeInvalido(item);
            base.Add(item);
        }

        public new void Atualizar(Turma item)
        {
            FalhaSeInvalido(item);
            base.Atualizar(item);
        }

        private void FalhaSeInvalido(Turma item) 
        {
            int index = _list.FindIndex(t => t.getId() != item.getId() && Utils.normaliza(t.getNomeTurma()) == Utils.normaliza(item.getNomeTurma()));

            if (index >= 0)
            {
                Turma t = _list[index];
                throw new ArgumentException($"Uma turma de mesmo nome {item.getNomeTurma()} ja esta cadastrada ({t.getNomeTurma()}).");
            }
        }
    }
}
