using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiroaplicativo
{
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text == "")
            {
                MessageBox.Show("voce precisa digitar o numero para calcular uma tabuada", "informaçao", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                    
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtnumero.Text);

                for(int i = 0; i < 10; i++)
                {
                    resultado = numero * i;
                    txttabuada.Text +=  numero + "x" + i + "=" + resultado + " \r\n";
                }

            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            txttabuada.Text = "";
        }
    }
}
