using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_cliente
{
    public class pessaojuridica : pessoa
    {
        private string nome, endereco, cnpj, ie;

        public override void gravarpessoa(string nome, string endereco, string documento1, string documento2)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cnpj = documento1;
            this.ie = documento2;
        }

        public string mostrarnome()
        {
            return nome;
        }

        public  string mostrarendereco()
        {
            return endereco;
        }

        public string mostrarcnpj()
        {
            return cnpj;
        }

        public string mostrarie()
        {
            return ie;
        }

    }
}
