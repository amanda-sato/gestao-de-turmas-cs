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
        
        public State() 
        {
            disciplinas = new DisciplinaRepo();
        }
    }
}
