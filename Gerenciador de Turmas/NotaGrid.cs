using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Retirado de https://www.youtube.com/watch?v=GyLlpBZGsrE&ab_channel=ProgrammersNerds
// e https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.datasource?view=windowsdesktop-7.0
namespace Gerenciador_de_Turmas
{
    internal class NotaGrid : IComparable<NotaGrid>
    {
        public int id {  get; set; }

        [DisplayName("Disciplina")]
        public string nomesDisc { get; set; }
        public int disciplinaId { get; set; }
        public string nomeAluno { get; set; }
        public int alunoId { get; set; }

        [DisplayName("Nota")]
        public double nota { get; set; }

        public NotaGrid()
        {
            id = -1;
            alunoId = -1;
            nomeAluno = "";
            disciplinaId = -1;
            nomesDisc = "";
            nota = -1;
        }

        public NotaGrid(int id, int alunoId, string nomeAluno, int disciplinaId, string nomesDisc, double nota)
        {
            this.id = id;
            this.alunoId = alunoId;
            this.nomeAluno = nomeAluno;
            this.disciplinaId = disciplinaId;
            this.nomesDisc = nomesDisc;
            this.nota = nota;
        }

        public int CompareTo(NotaGrid other)
        {
            if (other == null) return 1;

            return disciplinaId != other.disciplinaId
                ? disciplinaId.CompareTo(other.disciplinaId)
                : id.CompareTo(other.id);
        }
    }
}
