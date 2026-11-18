using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_cliente
{
    public class pesssoa_fisica : pessoa    
    {
        private string rg, cpf;

       public void gravarpessoa(string nome, string endereco, string rg, string cpf)
        {
            base.gravarpessoa(nome, endereco, rg, cpf); // Passa os 4 parâmetros para a classe base
            this.rg = rg;
            this.cpf = cpf;
        }

        public string mostrarcpf()
        {
            return cpf; 
        }

        public string mostrarrg()
        {
            return rg;
        }

        
    }
}
