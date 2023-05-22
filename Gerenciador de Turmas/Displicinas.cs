using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    internal class Displicinas
    {

        private double id;
        private string nomeDisc;
        private int quantidade;

        public Displicinas() 
        {
            id = 0;
            nomeDisc = "";

        }

        public Displicinas(double id, string nomeDisc)
        {
            this.id = id;
            this.nomeDisc = nomeDisc;
            
        }

        public double getId() { return id; }
        public string getNomeDisc() {  return nomeDisc; }


        public void setId(double id) { this.id = id; }
        public void setNomeDisc(string nomeDisc) {  this.nomeDisc = nomeDisc; }

        public override string ToString()
        {
            return $"{id} : {nomeDisc} ";
        }


    }
}
