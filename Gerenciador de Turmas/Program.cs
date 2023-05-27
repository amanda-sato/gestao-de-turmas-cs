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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(createState()));
        }
        static State createState()
        {
            State state = new State();

            state.disciplinas.Add(new Disciplina("Matemática"));
            state.disciplinas.Add(new Disciplina("Programação"));
            state.disciplinas.Add(new Disciplina("Biologia"));

            state.turmas.Add(new Turma("Desporto"));
            state.turmas.Add(new Turma("Tecnologias da informacao"));
            state.turmas.Add(new Turma("Artes II"));
            state.turmas.Add(new Turma("Historia"));

            return state;
        }
    }
}
