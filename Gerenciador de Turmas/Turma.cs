using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class Turma : IRegistro
    {
        private int id;
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

        public void deTxt(string txt)
        {
            string[] raw = txt.Split(',');
            id = int.Parse(raw[0]);
            nomeTurma = raw[1];
        }

        public int getId() { return id; }
        public string getNomeTurma() { return nomeTurma; }

        public string paraTxt()
        {
            return $"{id},{nomeTurma}";
        }

        public void setId(int id) { this.id = id; }
        public void setNomeTurma(string nomeTurma) { this.nomeTurma = nomeTurma; }

        public override string ToString()
        {
            return $"{id} - {nomeTurma}";
        }
    }
}
