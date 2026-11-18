using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_cliente
{
    public interface pessoaiter
    {
        void gravarpessoa(string nome, string ensereco, string documento1, string socumento2);

        string mostrarnome();
        string mostrarendereco();
        string mostrsrdocumento();
        string mostrsedumento2();
    }
}
