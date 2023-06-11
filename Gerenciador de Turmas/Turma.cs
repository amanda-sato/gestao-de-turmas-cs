using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    [DataContract]
    public class Turma : IRegistro
    {
        [DataMember]
        private int id;
        [DataMember]
        private string nomeTurma;

        public Turma()
        {
            id = -1;
            nomeTurma = "";
        }

        public Turma(string nomeTurma, int id = -1)
        {
            this.id = id;
            this.nomeTurma = nomeTurma;
        }

        public int getId() { return id; }
        public string getNomeTurma() { return nomeTurma; }

        public void setId(int id) { this.id = id; }
        public void setNomeTurma(string nomeTurma) { this.nomeTurma = nomeTurma; }

        public override string ToString()
        {
            return $"{id} - {nomeTurma}";
        }
    }
}
