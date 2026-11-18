using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        /*public class veiculo
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
        } // Fim da classe veiculo*/

        // Evento de clique do botao posicionado corretamente fora da classe veiculo
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if(txteixos.Visible == false)
            {
                veiculo novocarro = new veiculo();
                /*novocarro.gravamodelo(txtmodelo.Text);
          novocarro.gravaplaca(txtplaca.Text);
          novocarro.gravakm(txtkm.Text);

          txtcarro.Text += novocarro.mostramodelo() + "\t";
          txtcarro.Text += novocarro.mostraplaca() + "\t";
          txtcarro.Text += novocarro.mostrakm() + "\r\n";
          */

                novocarro.propriedadesmodelo = txtmodelo.Text;
                novocarro.propriedadesplaca = txtplaca.Text;
                novocarro.propriedadeskm = txtkm.Text;

                txtcarro.AppendText(novocarro.propriedadesmodelo + "\t");
                txtcarro.AppendText(novocarro.propriedadesplaca + "\t");
                txtcarro.AppendText(novocarro.propriedadeskm + Environment.NewLine.ToString());

            }
            else
            {
                caminhao novocaminhao = new caminhao();

                novocaminhao.propriedadesmodelo = txtmodelo.Text;
                novocaminhao.propriedadesplaca = txtplaca.Text;
                novocaminhao.propriedadeskm = txtkm.Text;
                novocaminhao.propriedadeseixos = txteixos.Text;

                txtcaminhao.AppendText(novocaminhao.propriedadesmodelo + "\t");
                txtcaminhao.AppendText(novocaminhao.propriedadesplaca + "\t");
                txtcaminhao.AppendText(novocaminhao.propriedadeskm + "\t");
                txtcaminhao.AppendText(novocaminhao.propriedadeseixos + Environment.NewLine.ToString());

            }

            limpar();





        }

        private void btncaminhao_Click(object sender, EventArgs e)
        {
            lbleixo.Visible = true;
            txteixos.Visible = true;
        }

        private void btncarros_Click(object sender, EventArgs e)
        {

            lbleixo.Visible = false;
            txteixos.Visible = false;
        }

        private void limpar()
        {
            txtmodelo.Clear();
            txtplaca.Clear();
            txtkm.Clear();
            txteixos.Clear();
        }
    }

    public class veiculo
    {
        string modelo, placa, km;

        public string propriedadesmodelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        public string propriedadesplaca
        {
          set{ placa = value; }
          get{ return placa; }
        }
        public string propriedadeskm
        {
            set { km = value; }
            get { return km; }
        }

    }

    public class caminhao : veiculo
    {
        public string propriedadeseixos { set; get; }
    }
}
