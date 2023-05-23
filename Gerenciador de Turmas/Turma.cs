using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    internal class Turma
    {
        private double id;
        private string nomeTurma;

        public Turma()
        {
            id = 0;
            nomeTurma = "";
        }

        public Turma(double id, string nomeTurma)
        {
            this.id = id;
            this.nomeTurma = nomeTurma;
        }

        public double getId() { return id; }
        public string getNomeTurma() { return nomeTurma; }

        public void setId(double id) { this.id = id; }
        public void setNomeTurma(string nomeTurma) { this.nomeTurma = nomeTurma; }

        public override string ToString()
        {
            return $"{id} - {nomeTurma}";
        }
    }
}
