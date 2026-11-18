using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_de_cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnpessoafisica_Click(object sender, EventArgs e)
        {
            gbfisica.Visible = true;
            gbjuridica.Visible = false;
        }

        private void btnpessoajuridica_Click(object sender, EventArgs e)
        {
            gbfisica.Visible = false;
            gbjuridica.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbfisica.Visible = false;
            gbjuridica.Visible = false;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if(gbfisica.Visible == true)
            {
                pesssoa_fisica novapessoafisica = new pesssoa_fisica();

                novapessoafisica.gravarpessoa(txtnome1.Text, txtendereco1.Text, txtrg.Text, txtcpf.Text);

                txtmostrafisica.AppendText(novapessoafisica.mostrarnome() + "\t");
                txtmostrafisica.AppendText(novapessoafisica.mostrarendereco() + "\t");
                txtmostrafisica.AppendText(novapessoafisica.mostrarrg() + "\t");
                txtmostrafisica.AppendText(novapessoafisica.mostrarcpf() + Environment.NewLine.ToString());
                limpar();

            }
                        
            
            else
            {
                pessoajuridica novapessoajuridica = new pessoajuridica(txtnome2.Text, txtendereço2.Text, txtcnpj.Text, txtle.Text);

              
                txtmostrajuridica.AppendText(novapessoajuridica.mostrarnome() + "\t");
                txtmostrajuridica.AppendText(novapessoajuridica.mostrarendereco() + "\t");
                txtmostrajuridica.AppendText(novapessoajuridica.mostrarcnpj() + "\t");
                txtmostrajuridica.AppendText(novapessoajuridica.mostrarie() + Environment.NewLine.ToString());
                limpar();


                
            }
        }
        public void limpar()
        {
            if(gbfisica.Visible == true)
            {
                txtnome1.Text = "";
                txtendereco1.Text = "";
                txtrg.Text = "";
                txtcpf.Text = "";
            }
            else
            {
                txtnome2.Text = "";
                txtendereço2.Text = "";
                txtcnpj.Text = "";
                txtle.Text = "";
            }
        }
    }

   /* public class pessoa
    {
        private string nome;
        private string endereco;

        public string propriedadenome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string propriedadeendereco
        {

            set { endereco = value; }
            get { return endereco; }
        }
    }*/

   /* public class pessoafisica : pessoa
    {
        public string propriedadesrg { set; get; }
        public string propridadescpf { set; get; }

    }

    public class pessoajuridica : pessoa
    {
        public string propiedadecnpj { set; get; }
        public string propriedadeie { set; get;  }
    }*/
}







