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
        private int quantidade;

        public Turma()
        {
            id = 0;
            nomeTurma = "";
            quantidade = 0;

        }

        public Turma(double id, string nomeDisc, int quantidade)
        {
            this.id = id;
            this.nomeTurma = nomeDisc;
            this.quantidade = quantidade;
        }

        public double getId() { return id; }
        public string getNomeDisc() { return nomeTurma; }
        public int getQuantidade() { return quantidade; }


        public void setId(double id) { this.id = id; }
        public void setNomeDisc(string nomeTurma) { this.nomeTurma = nomeTurma; }
        public void setQuantidade(int quantidade) { this.quantidade = quantidade; }

        public override string ToString()
        {
            return $"{nomeTurma} ({id} - {quantidade}) ";
        }


    }
}
