using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class Turma : IRegistro
    {
        private static int nextId = 1;

        private int id;
        private string nomeTurma;

        public Turma()
        {
            id = nextId++;
            nomeTurma = "";
        }

        public Turma(string nomeTurma, int id = -1)
        {
            this.id = id >= 0 ? id : nextId++;
            this.nomeTurma = nomeTurma;
        }

        public static int getNextId()
        {
            return nextId;
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
