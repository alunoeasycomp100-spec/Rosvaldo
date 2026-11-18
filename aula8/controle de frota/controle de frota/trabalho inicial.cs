using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_frota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Classe veiculo declarada no nivel do Form1
        public class veiculo
        {
            private string modelo, placa, km;

            public void gravamodelo(string modelo)
            {
                this.modelo = modelo;
            }

            public void gravaplaca(string placa)
            {
                this.placa = placa;
            }

            public void gravakm(string km)
            {
                this.km = km;
            }

            public string mostramodelo()
            {
                return modelo;
            }

            public string mostraplaca()
            {
                return placa;
            }

            public string mostrakm()
            {
                return km;
            }
        } // Fim da classe veiculo

        // Evento de clique do botao posicionado corretamente fora da classe veiculo
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            veiculo novocarro = new veiculo();

            novocarro.gravamodelo(txtmodelo.Text);
            novocarro.gravaplaca(txtplaca.Text);
            novocarro.gravakm(txtkm.Text);

            txtcarro.Text += novocarro.mostramodelo() + "\t";
            txtcarro.Text += novocarro.mostraplaca() + "\t";
            txtcarro.Text += novocarro.mostrakm() + "\r\n";
        }


    }
}
