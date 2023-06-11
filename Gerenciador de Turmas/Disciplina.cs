using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    [DataContract]
    public class Disciplina : IRegistro
    {
        [DataMember]
        private int id;
        [DataMember]
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
