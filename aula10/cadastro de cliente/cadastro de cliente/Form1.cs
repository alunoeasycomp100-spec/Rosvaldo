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
            if (gbfisica.Visible == true)
            {
                pessoafisica novapessoafisica = new pessoafisica();

                novapessoafisica.propriedadenome = txtnome1.Text;
                novapessoafisica.propriedadeendereco = txtendereco1.Text;
                novapessoafisica.propriedadesrg = txtrg.Text;
                novapessoafisica.propridadescpf = txtcpf.Text;

                txtmostrafisica.AppendText(novapessoafisica.propriedadenome + "\t");
                txtmostrafisica.AppendText(novapessoafisica.propriedadeendereco + "\t");
                txtmostrafisica.AppendText(novapessoafisica.propriedadesrg + "\t");
                txtmostrafisica.AppendText(novapessoafisica.propridadescpf + Environment.NewLine.ToString());

                limpar();
            }
            else
            {
                pessoajuridica novapessoajuridica = new pessoajuridica();

                novapessoajuridica.propriedadenome = txtnome2.Text;
                novapessoajuridica.propriedadeendereco = txtendereço2.Text;
                novapessoajuridica.propiedadecnpj = txtcnpj.Text;
                novapessoajuridica.propriedadeie = txtle.Text;

                txtmostrajuridica.AppendText(novapessoajuridica.propriedadenome +"\t");
                txtmostrajuridica.AppendText(novapessoajuridica.propriedadeendereco + "\t");
                txtmostrajuridica.AppendText(novapessoajuridica.propiedadecnpj + "\t");
                txtmostrajuridica.AppendText(novapessoajuridica.propriedadeie + Environment.NewLine.ToString());

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

    public class pessoa
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
    }

    public class pessoafisica : pessoa
    {
        public string propriedadesrg { set; get; }
        public string propridadescpf { set; get; }

    }

    public class pessoajuridica : pessoa
    {
        public string propiedadecnpj { set; get; }
        public string propriedadeie { set; get;  }
    }
}







