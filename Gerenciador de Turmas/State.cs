using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class State
    {
        public DisciplinaRepo disciplinas;
        public TurmaRepo turmas;
        public AlunoRepo alunos;

        public State() 
        {
            disciplinas = new DisciplinaRepo();
            turmas = new TurmaRepo();
            alunos = new AlunoRepo();
        }
    }
}
