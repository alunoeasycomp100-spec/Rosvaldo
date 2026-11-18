using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_cliente
{
    public class pessoa
    {
        private string nome, endereco;

        public void gravarpessoa(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }

        public string mostrarnome()
        {
            return nome;
        }

        public string mostrarendereco()
        {
            return endereco;
        }

    }
}
