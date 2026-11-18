using System;
using System.Collections.Generic;
using System.Text;

namespace funcionario
{
    public class designer : ifuncionario
    {
        string nome, cargo;
        decimal salario;

        public void salvar(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string retornarcargo()
        {
            return cargo;        
        }

        public string retornarnome()
        {
            return nome;
        }

        public decimal retornarsalario()
        {
            return salario;
        }

      
    }
}
