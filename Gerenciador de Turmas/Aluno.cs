using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    internal class Aluno
    {
        private int matricula;
        private string nomeAluno;
        private string genero;


        public Aluno()
        {
            matricula = 0;
            nomeAluno = "";
            genero = "";
        }

        public Aluno(int matricula, string nomeAluno, string genero)
        {
            this.matricula = matricula;
            this.nomeAluno = nomeAluno;
            this.genero = genero;
        }

        public int getMatricula() { return matricula; }

        public string getNomeAluno() {  return nomeAluno; }

        public string getGenero() { return genero; }


        public void setMatricula(int matricula) { this.matricula = matricula; }

        public void setNomeAluno(string nomeAluno) { this.nomeAluno = nomeAluno; }

        public void setGenero(string genero) { this.genero = genero; }

        public override string ToString()
        {
            return $"{matricula} - {nomeAluno} - {genero}";
        }
    }
}
