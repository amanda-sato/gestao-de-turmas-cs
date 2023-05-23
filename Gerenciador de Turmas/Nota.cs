using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    internal class Nota
    {

        private int alunoId;
        private double disciplinaId;
        private int id;
        private double nota;

        public Nota()
        {
            alunoId = 0;
            disciplinaId = 0;
            id = 0;
            nota = 0;

        }       

        public Nota(int alunoId, double disciplinaId, int id, double nota)
        {
            this.alunoId = alunoId;
            this.disciplinaId = disciplinaId;
            this.id = id;
            this.nota = nota;
        }

        public int getAlunoId() {  return alunoId; }
        public double getDisciplinaId() {  return disciplinaId; }
        public int getId() { return id; }
        public double getNota() {  return nota; }

        public void setAlunoId(int alunoId) { this.alunoId = alunoId; }

        public void setDisciplinaId(double disciplinaId) { this.disciplinaId = disciplinaId; }

        public void setId(int id) { this.id = id; }

        public void setNota(double nota) { this.nota = nota; }

        public override string ToString()
        {
            return $"{alunoId} - {disciplinaId} : {id} - {nota}";
        }


    }
}
