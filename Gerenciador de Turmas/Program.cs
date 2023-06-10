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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            state = new State();
            state.carrega();

            if (state.estaVazio())
            {
                state.preenche();
            }

            Application.Run(new MainForm(state));

            state.salva();
        }

        public static State GetState() => state;
    }
}
