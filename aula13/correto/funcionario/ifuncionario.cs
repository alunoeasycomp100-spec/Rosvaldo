using System;
using System.Collections.Generic;
using System.Text;

namespace funcionario
{
    public interface ifuncionario
    {
        void salvar(string nome, string cargo, decimal salario);

        string retornarnome();
        string retornarcargo();
        decimal retornarsalario();
    }
}
