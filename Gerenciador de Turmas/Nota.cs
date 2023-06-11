using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    [DataContract]
    public class Nota : IRegistro
    {
        [DataMember]
        private int id;
        [DataMember]
        private int alunoId;
        [DataMember]
        private int disciplinaId;
        [DataMember]
        private double nota;

        public Nota()
        {
            id = -1;
            alunoId = 0;
            disciplinaId = 0;
            nota = 0;
        }       

        public Nota(int alunoId, int disciplinaId, double nota, int id = -1)
        {
            this.id = id;
            this.alunoId = alunoId;
            this.disciplinaId = disciplinaId;
            setNota(nota);
        }

        public int getAlunoId() {  return alunoId; }
        public int getDisciplinaId() {  return disciplinaId; }
        public int getId() { return id; }
        public double getNota() {  return nota; }

        public void setAlunoId(int alunoId) { this.alunoId = alunoId; }

        public void setDisciplinaId(int disciplinaId) { this.disciplinaId = disciplinaId; }

        public void setId(int id) { this.id = id; }

        public void setNota(double nota) 
        {
            if (nota < 0 || nota > 20)
            {
                throw new ArgumentException($"A nota precisa ser um valor entre 0 e 20.\n{nota} foi inserido.");
            }

            this.nota = nota; 
        }

        public override string ToString()
        {
            return $"{alunoId} - {disciplinaId} : {id} - {nota}";
        }

        public static implicit operator NotaGrid(Nota n)
        {
            return new NotaGrid(
                id: n.getId(),
                alunoId: n.getAlunoId(),
                nomeAluno: Program.GetState().alunos.GetPorId(n.getAlunoId()).getNomeAluno(),
                disciplinaId: n.getDisciplinaId(),
                nomesDisc: Program.GetState().disciplinas.GetPorId(n.getDisciplinaId()).getNomeDisc(),
                nota: n.getNota()
            );
        }
    }
}
