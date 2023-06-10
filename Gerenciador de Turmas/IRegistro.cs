using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Turmas
{
    public interface IRegistro
    {
        void setId(int id);
        int getId();
        string paraTxt();
        void deTxt(string txt);
    }
}
