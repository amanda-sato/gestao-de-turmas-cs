using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class Aluno : IRegistro
    {
        private static int nextId = 1;

        private int matricula;
        private int turmaId;

        private string nomeAluno;
        private string genero;

        public Aluno()
        {
            matricula = nextId++;
            nomeAluno = "";
            genero = "";
            turmaId = -1;
        }

        public Aluno(string nomeAluno, string genero, int turmaId, int matricula = -1)
        {
            this.matricula = matricula >= 0 ? matricula : nextId++;
            this.nomeAluno = nomeAluno;
            this.turmaId = turmaId;
            this.genero = genero;
        }

        public static int getNextId()
        {
            return nextId;
        }

        public int getMatricula() { return matricula; }

        public string getNomeAluno() {  return nomeAluno; }

        public string getGenero() { return genero; }

        public int getTurmaId() { return turmaId; }


        public Aluno setMatricula(int matricula) 
        { 
            this.matricula = matricula;
            return this;
        }

        public Aluno setNomeAluno(string nomeAluno) 
        { 
            this.nomeAluno = nomeAluno;
            return this;
        }

        public Aluno setGenero(string genero) 
        { 
            this.genero = genero;
            return this;
        }

        public Aluno setTurmaId(int turmaId) 
        { 
            this.turmaId = turmaId;
            return this;
        }

        public override string ToString()
        {
            return $"{matricula} - {nomeAluno} - {genero}";
        }

        public int getId()
        {
            return matricula;
        }

        public string situacao(Disciplina disciplina)
        {
            double nota = Program.GetState().notas.NotaAlunoEm(disciplina, this);

            if (nota < 0)
            {
                return "Sem dados";
            }

            return nota >= 10 ? "Aprovado" : "Reprovado";
        }
    }
}
