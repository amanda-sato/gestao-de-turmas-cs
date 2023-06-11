using System;
using System.Text.RegularExpressions;

namespace Gerenciador_de_Turmas
{
    public class DisciplinaRepo : Repo<Disciplina>
    {
        public new void Add(Disciplina item)
        {
            FalhaSeInvalido(item);
            base.Add(item);
        }

        public new void Atualizar(Disciplina item)
        {
            FalhaSeInvalido(item);
            base.Atualizar(item);
        }

        private void FalhaSeInvalido(Disciplina item)
        {
            int index = _list.FindIndex(d => d.getId() != item.getId() && Utils.normaliza(d.getNomeDisc()) == Utils.normaliza(item.getNomeDisc()));

            if (index >= 0)
            {
                Disciplina d = _list[index];
                throw new ArgumentException($"Uma disciplina de mesmo nome {item.getNomeDisc()} ja esta cadastrada ({d.getNomeDisc()}).");
            }
        }
    }
}
