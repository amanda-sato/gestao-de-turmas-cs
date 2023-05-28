using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Gerenciador_de_Turmas
{
    internal static class Program
    {
        private static State state;
        private static MainForm mainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CreateMainForm());
        }

        public static MainForm GetMainForm()
        {
            return mainForm;
        }

        static MainForm CreateMainForm()
        {
            mainForm = new MainForm(CreateState());
            return mainForm;
        }

        public static State GetState()
        {
            return state;
        }

        static State CreateState()
        {
            state = new State();

            state.disciplinas.Add(new Disciplina("Matemática"));
            state.disciplinas.Add(new Disciplina("Programação"));
            state.disciplinas.Add(new Disciplina("Biologia"));

            state.turmas.Add(new Turma("A"));
            state.turmas.Add(new Turma("B"));
            state.turmas.Add(new Turma("C"));
            state.turmas.Add(new Turma("D"));

            state.alunos.Add(new Aluno("Jose Emanuel", "M", 1));
            state.alunos.Add(new Aluno("Maria Joaquina", "F", 1));
            state.alunos.Add(new Aluno("Emilia Clark", "F", 2));
            state.alunos.Add(new Aluno("Joaquim Soares", "M", 2));
            state.alunos.Add(new Aluno("Xinforinfula Mercedes", "F", 3));

            // Notas Jose Emanuel
            state.notas.Add(new Nota(1, 1, 10.50));
            state.notas.Add(new Nota(1, 2, 15.234));
            state.notas.Add(new Nota(1, 2, 16.77));

            // Notas Maria Joaquina
            state.notas.Add(new Nota(2, 1, 12.00));
            state.notas.Add(new Nota(2, 2, 13.00));
            state.notas.Add(new Nota(2, 2, 14.645));

            // Notas Emilia Clark
            state.notas.Add(new Nota(3, 1, 20.00));
            
            // Notas Joaquim Soares
            state.notas.Add(new Nota(4, 1, 12.00));
            
            // Notas Xiforinfula Mercedes
            state.notas.Add(new Nota(5, 1, 14.00));

            return state;
        }
    }
}
