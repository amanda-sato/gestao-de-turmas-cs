using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Gerenciador_de_Turmas
{
    public class State
    {
        public DisciplinaRepo disciplinas;
        public TurmaRepo turmas;
        public AlunoRepo alunos;
        public NotaRepo notas;

        public State() 
        {
            disciplinas = new DisciplinaRepo();
            turmas = new TurmaRepo();
            alunos = new AlunoRepo();
            notas = new NotaRepo();
        }

        public void carrega()
        {
            disciplinas.carregarDe("disciplinas.json");
            turmas.carregarDe("turmas.json");
            alunos.carregarDe("alunos.json");
            notas.carregarDe("notas.json");
        }

        public void salva()
        {
            disciplinas.salvarPara("disciplinas.json");
            turmas.salvarPara("turmas.json");
            alunos.salvarPara("alunos.json");
            notas.salvarPara("notas.json");
        }

        public void preenche()
        {
            disciplinas.Add(new Disciplina("Matemática"));
            disciplinas.Add(new Disciplina("Programação"));
            disciplinas.Add(new Disciplina("Biologia"));

            turmas.Add(new Turma("A"));
            turmas.Add(new Turma("B"));
            turmas.Add(new Turma("C"));
            turmas.Add(new Turma("D"));

            alunos.Add(new Aluno("Jose Emanuel", "M", 1));
            alunos.Add(new Aluno("Maria Joaquina", "F", 1));
            alunos.Add(new Aluno("Emilia Clark", "F", 2));
            alunos.Add(new Aluno("Joaquim Soares", "M", 2));
            alunos.Add(new Aluno("Xinforinfula Mercedes", "F", 3));

            // Notas Jose Emanuel
            notas.Add(new Nota(1, 1, 10.50));
            notas.Add(new Nota(1, 2, 16.77));

            // Notas Maria Joaquina
            notas.Add(new Nota(2, 1, 12.00));
            notas.Add(new Nota(2, 2, 14.645));

            // Notas Emilia Clark
            notas.Add(new Nota(3, 1, 20.00));

            // Notas Joaquim Soares
            notas.Add(new Nota(4, 1, 12.00));

            // Notas Xiforinfula Mercedes
            notas.Add(new Nota(5, 1, 14.00));
        }

        public bool estaVazio()
        {
            return disciplinas.Count() <= 0 && turmas.Count() <= 0 && alunos.Count() <= 0 && notas.Count() <= 0;
        }
    }
}
