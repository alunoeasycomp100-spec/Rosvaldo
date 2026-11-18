using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    public class objetocalculo : abstrctcalculo
    {
        public override double valorvisor { get; set; }
        public override double valoranterior { get ; set ; }
        public override double valorresultado { get ; set; }
        public override string operacao { get ; set; }

        public override double calculo()
        {
            switch (operacao)
            {
                case "+":
                    valorresultado = valoranterior + valorvisor;
                    break;

                case "-":
                    valorresultado = valoranterior - valorvisor;
                    break;
                case "*":
                    valorresultado = valoranterior * valorvisor;
                    break;
                case "/":
                    valorresultado = valoranterior / valorvisor;
                    break;

                case "r":
                    /*double valorraiz = valorvisor;

                    for (int i = 0; i<10; i++)
                    {
                        valorraiz = (valorraiz / 2) + valorvisor / (2 + valorraiz);
                    }

                    valorresultado = valorraiz;*/

                    valorresultado = Math.Sqrt(valorvisor);
                    break;




                default:
                    break;
            }

            return valorresultado;
        }
    }
}
