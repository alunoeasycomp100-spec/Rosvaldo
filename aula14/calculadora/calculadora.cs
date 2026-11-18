using System.DirectoryServices.ActiveDirectory;

namespace calculadora
{
    public partial class calculadora : Form
    {
        double valorvisor = 0, valoranterior = 0;
        string operaxao = "";
        bool primeiraoperacao = true, botaoigual = false;
        public calculadora()
        {
            InitializeComponent();
        }

        private void clicoubotao(object sender, EventArgs e)
        {
            if (txtvisor.Text == "0")
            {
                txtvisor.Clear();
            }

            Button botaoacionado = (Button)sender;

            switch (botaoacionado.Name)
            {
                case "btn1":
                    txtvisor.Text += "1";
                    break;

                case "btn2":
                    txtvisor.Text += "2";
                    break;

                case "btn3":
                    txtvisor.Text += "3";
                    break;

                case "btn4":
                    txtvisor.Text += "4";
                    break;

                case "btn5":
                    txtvisor.Text += "5";
                    break;

                case "btn6":
                    txtvisor.Text += "6";
                    break;

                case "btn7":
                    txtvisor.Text += "7";
                    break;

                case "btn8":
                    txtvisor.Text += "8";
                    break;

                case "btn9":
                    txtvisor.Text += "9";
                    break;

                case "btn0":
                    txtvisor.Text += "0";
                    break;

                case "btnvirgula":
                    if (txtvisor.Text == "")
                    {
                        txtvisor.Text += "0,";
                    }
                    else
                    {
                        txtvisor.Text += ",";
                    }
                    break;
                default:
                    break;


            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtvisor.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text.Remove(txtvisor.Text.Length - 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (primeiraoperacao)
            {
                valoranterior = Convert.ToDouble(txtvisor.Text);

                if(botaoigual == false)
                {
                    txthistorico.Text += txtvisor.Text;
                }

                txtvisor.Clear();
                operaxao = "+";
                primeiraoperacao = false;
                
            }
            else
            {
                valorvisor = Convert.ToDouble(txtvisor);

                txthistorico.Text += operaxao + txtvisor.Text;
                txtvisor.Text = Convert.ToString(valoranterior + valorvisor);/
            }
        }
    }
}
