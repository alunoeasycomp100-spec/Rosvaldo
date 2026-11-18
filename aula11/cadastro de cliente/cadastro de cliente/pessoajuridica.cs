using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_cliente
{
    public class pessoajuridica : pessoa
    {
        private string cnpj, ie;

        public pessoajuridica(string nome, string endereco, string cnpj, string ie)
        {
            base.gravarpessoa(nome, endereco);
            this.cnpj = cnpj;
            this.ie = ie;
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
