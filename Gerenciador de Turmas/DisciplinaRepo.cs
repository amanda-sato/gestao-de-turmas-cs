using System;
using System.Text.RegularExpressions;

namespace Gerenciador_de_Turmas
{
    public class DisciplinaRepo : Repo<Disciplina>
    {
        public override void Add(Disciplina item)
        {
            int index = _list.FindIndex(d => Utils.normaliza(d.getNomeDisc()) == Utils.normaliza(item.getNomeDisc()));

            if (index >= 0)
            {
                Disciplina d = _list[index];
                throw new ArgumentException($"Uma disciplina de mesmo nome {item.getNomeDisc()} ja esta cadastrada ({d.getNomeDisc()}).");
            }

            base.Add(item);
        }
    }
}
