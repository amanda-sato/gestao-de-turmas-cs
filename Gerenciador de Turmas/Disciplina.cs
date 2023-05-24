using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class Disciplina : IRegistro
    {
        private static int nextId = 1;

        private int id;
        private string nomeDisc;
        
        public Disciplina()
        {
            id = 0;
            nomeDisc = "";

        }

        public Disciplina(string nomeDisc, int id = -1)
        {
            this.id = id >= 0 ? id : nextId++;
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
