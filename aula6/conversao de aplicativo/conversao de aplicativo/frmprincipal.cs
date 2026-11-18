using System.Diagnostics.Eventing.Reader;

namespace conversao_de_aplicativo
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtvalor.Text);

            if (rbcelcius1.Checked == true)
            {
                if (rbkelvin2.Checked == true)
                {
                    txtresulatado.Text = (valor + 273) + " °k";
                }

                else
                    if (rbfahrenheit2.Checked == true)
                    {
                        txtresulatado.Text = (valor * 1.8 + 32) + " °f";
                    }

                    else
                    {
                        txtresulatado.Text = valor + " °c";
                    }
            }
            else if (rbfahrenheit1.Checked)
            {
                if (rbCelcius2.Checked)
                {
                    txtresulatado.Text = ((valor - 32) / 1.8) + " °C";
                }
                else if (rbkelvin2.Checked)
                {
                    txtresulatado.Text = (((valor - 32) / 1.8) + 273.15) + " °K";
                }
                else
                {
                    txtresulatado.Text = valor + " °F";
                }
            }
            // De Kelvin para outras escalas
            else if (rbkelvin1.Checked)
            {
                if (rbCelcius2.Checked)
                {
                    txtresulatado.Text = (valor - 273.15) + " °C";
                }
                else if (rbfahrenheit2.Checked)
                {
                    txtresulatado.Text = (((valor - 273.15) * 1.8) + 32) + " °F";
                }
                else
                {
                    txtresulatado.Text = valor + " °K";
                }
            }
        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de texto
            txtvalor.Text = "";
            txtresulatado.Clear();

            // Desmarca os RadioButtons de entrada de forma segura
            foreach (Control componente in gpentrada.Controls)
            {
                if (componente is RadioButton radio)
                {
                    radio.Checked = false;
                }
            }

            // Desmarca os RadioButtons de saída de forma segura
            foreach (Control componente in gpsaida.Controls)
            {
                if (componente is RadioButton radio)
                {
                    radio.Checked = false;
                }
            }
        }
    }
}

         