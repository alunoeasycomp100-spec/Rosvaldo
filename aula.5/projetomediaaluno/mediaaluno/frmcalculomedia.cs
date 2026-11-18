using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaaluno
{
    public partial class frmcalculomedia : Form
    {
        public frmcalculomedia()
        {
            InitializeComponent();
        }

        private void frmcalculomedia_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, trabalho;

            nota1 = Convert.ToDouble(txtnota1.Text) * Convert.ToDouble(cbopesonota1.Text);
            nota2 = double.Parse(txtnota2.Text) * double.Parse(cbopesonota2.Text);
            trabalho = Convert.ToDouble(txttrabalho.Text) * Convert.ToDouble(cbopesotrabalho.Text);

            double media = nota1 + nota2 + trabalho;

            txtmediafinal.Text = media.ToString();

            double qdeaulas, qdefaltas;


            qdeaulas = Convert.ToDouble(txtqdeaulas.Text);
            qdefaltas = Convert.ToDouble(txtqdefaltas.Text);


            double porcentagempresenca = 100 - ((qdefaltas / qdeaulas) * 100);

            txtaproveitamento.Text = Convert.ToString(((media * 10) + (porcentagempresenca)) / 2) + "%";

            if (txtrecuperacao.Text == "")
            {
                if (media >= Convert.ToDouble(numnotacorte.Value) && porcentagempresenca >= 75)
                {
                    lblsituacao.Text = "aprovado";
                    lblsituacao.ForeColor = Color.Green;
                }

                else
                    if (media <= 2.5 || porcentagempresenca < 75)
                    {
                        lblsituacao.Text = "reprovado";
                        lblsituacao.ForeColor = Color.Firebrick;

                    }
                    else
                    {
                        lblsituacao.Text = "recuperacao";
                        lblsituacao.ForeColor = Color.Firebrick;
                    }
            }
            else
            {
                media = (media + Convert.ToDouble(txtrecuperacao.Text)) / 2;

                txtaproveitamento.Text = Convert.ToString(((media * 10) + (porcentagempresenca)) / 2) + "%";

                if (media >= 5)
                {
                    lblsituacao.Text = "aprovado";
                    lblsituacao.ForeColor = Color.Green;
                }
                else
                {
                    lblsituacao.Text = "reprovado";
                    lblsituacao.ForeColor = Color.Firebrick;
                }

                    
                    
            }
            

            txtmediafinal.Text = media.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lblsituacao.Text = "";
            txtrecuperacao.Text = string.Empty;

            // laço de repetiçao que ira percorrer todos os componentes de formulario
            foreach (Control componente in this.Controls)
            {
                if (componente is TextBox)
                {
                    (componente as TextBox).Clear();
                }
                else
                {
                    if (componente is ComboBox)
                    {
                        (componente as ComboBox).SelectedIndex = -1;
                    }
                    else
                    {
                        if (componente is NumericUpDown)
                        {
                            (componente as NumericUpDown).Value = 5;
                        }
                    }
                }        
                
                
                            }
        }
    }
}



