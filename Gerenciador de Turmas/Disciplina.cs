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
            id = -1;
            nomeDisc = "";
        }

        public Disciplina(string nomeDisc, int id = -1)
        {
            this.id = id;
            this.nomeDisc = nomeDisc;
        }

        public void deTxt(string txt)
        {
            string[] raw = txt.Split(',');
            id = int.Parse(raw[0]);
            nomeDisc = raw[1];
        }

        public int getId() { return id; }
        public string getNomeDisc() { return nomeDisc; }

        public string paraTxt()
        {
            return $"{id},{nomeDisc}";
        }

        public void setId(int id) { this.id = id; }
        public void setNomeDisc(string nomeDisc) { this.nomeDisc = nomeDisc; }

        public override string ToString()
        {
            return $"{id} : {nomeDisc} ";
        }
    }
}
