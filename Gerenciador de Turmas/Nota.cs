using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public class Nota : IRegistro
    {
        private static int nextId = 1;

        private int id;
        private int alunoId;
        private int disciplinaId;
        private double nota;

        public Nota()
        {
            id = nextId++;
            alunoId = 0;
            disciplinaId = 0;
            nota = 0;
        }       

        public Nota(int alunoId, int disciplinaId, double nota, int id = -1)
        {
            this.id = id >= 0 ? id : nextId++;
            this.alunoId = alunoId;
            this.disciplinaId = disciplinaId;
            this.nota = nota;
        }

        public static int getNextId()
        {
            return nextId;
        }

        public int getAlunoId() {  return alunoId; }
        public int getDisciplinaId() {  return disciplinaId; }
        public int getId() { return id; }
        public double getNota() {  return nota; }

        public void setAlunoId(int alunoId) { this.alunoId = alunoId; }

        public void setDisciplinaId(int disciplinaId) { this.disciplinaId = disciplinaId; }

        public void setId(int id) { this.id = id; }

        public void setNota(double nota) { this.nota = nota; }

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
