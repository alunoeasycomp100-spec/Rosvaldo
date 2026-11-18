using System;
using System.Collections.Generic;
using System.Text;

namespace funcionario
{
    public abstract class funcionario
    {
        public abstract void salvar(string nome, string cargo, decimal salario);

        public abstract string retornanome();

        public abstract string retornacargo();

        public abstract decimal retornasalario();
        
    }




   
       /* private string nome, cargo;
        private decimal salario;
      
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string retornarnome()
        {
            return nome;
                  
        }
        public string retornarcargo()
        {
            return cargo;
        }

        public decimal retornarsalario()
        {
            return salario;
        }*/

    
}
