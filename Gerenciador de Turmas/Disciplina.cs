using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class Disciplina : IRegistro
    {
        private int id;
        private string nomeDisc;
        
        public Disciplina()
        {
            id = 0;
            nomeDisc = "";

        }

        public Disciplina(int id, string nomeDisc)
        {
            this.id = id;
            this.nomeDisc = nomeDisc;

        }

        public int getId() { return id; }
        public string getNomeDisc() { return nomeDisc; }


        public void setId(int id) { this.id = id; }
        public void setNomeDisc(string nomeDisc) { this.nomeDisc = nomeDisc; }


        

        public override string ToString()
        {
            return $"{id} : {nomeDisc} ";
        }
    }
}
