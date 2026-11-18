using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    public abstract class abstrctcalculo
    {
        public abstract double valorvisor { set; get; }
        public abstract double valoranterior { set; get; }
        public abstract double valorresultado {  set; get; }
        public abstract string operacao {  set; get; }

        public abstract double calculo();
    }
}
