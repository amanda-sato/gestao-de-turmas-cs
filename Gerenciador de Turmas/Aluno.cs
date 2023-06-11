using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    [DataContract]
    public class Aluno : IRegistro
    {
        [DataMember]
        private int matricula;
        [DataMember]
        private int turmaId;

        [DataMember]
        private string nomeAluno;
        [DataMember]
        private string genero;

        public Aluno()
        {
            matricula = -1;
            nomeAluno = "";
            genero = "";
            turmaId = -1;
        }

        public Aluno(string nomeAluno, string genero, int turmaId, int matricula = -1)
        {
            this.matricula = matricula;
            this.nomeAluno = nomeAluno;
            this.turmaId = turmaId;
            this.genero = genero;
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

        public void setId(int id)
        {
            setMatricula(id);
        }
    }
}
