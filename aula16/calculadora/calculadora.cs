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
            if (txtvisor.Text == "0" || botaoigual == true)
            {
                txtvisor.Clear();
                botaoigual = false;
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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvisor.Clear();
            txthistorico.Clear();
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text.Remove(txtvisor.Text.Length - 1);
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (primeiraoperacao)
            {
                valoranterior = Convert.ToDouble(txtvisor.Text);

                if (botaoigual == false)
                {
                    txthistorico.Text += txtvisor.Text;
                }

                txtvisor.Clear();
                operaxao = "+";
                primeiraoperacao = false;
            }
            else
            {
                valorvisor = Convert.ToDouble(txtvisor.Text);

                txtvisor.Text += operaxao + txtvisor.Text;
                //txtvisor.Text = Convert.ToString(valoranterior + valorvisor);
                // txtvisor.Text = Convert.ToString(calculo());

                objetocalculo novocalculo = new objetocalculo();

                novocalculo.valorvisor = this.valorvisor;
                novocalculo.valoranterior = this.valoranterior;

                novocalculo.operacao = this.operaxao;

                txtvisor.Text = Convert.ToString(novocalculo.calculo());
                operaxao = "+";
                txthistorico.Text += "+" + txtvisor.Text;
                valoranterior = Convert.ToDouble(txtvisor.Text);
                botaoigual = true;
            }
        }

        private void btnlimpar_click(object sender, EventArgs e)
        {
            txtvisor.Clear();
            txthistorico.Clear();
            valoranterior = 0;
            valoranterior = 0;

            operaxao = "";
            primeiraoperacao = true;
            botaoigual = false;

        }




        private void btndivide_Click(object sender, EventArgs e)
        {
            if (primeiraoperacao)
            {
                valoranterior = Convert.ToDouble(txtvisor.Text);

                if (botaoigual == false)
                {
                    txthistorico.Text += txtvisor.Text;
                }

                txtvisor.Clear();
                operaxao = "/";
                primeiraoperacao = false;
            }
            else
            {
                valorvisor = Convert.ToDouble(txtvisor.Text);

                txtvisor.Text += operaxao + txtvisor.Text;
                //txtvisor.Text = Convert.ToString(valoranterior / valorvisor);
                //txtvisor.Text = Convert.ToString(calculo());
                objetocalculo novocalculo = new objetocalculo();

                novocalculo.valorvisor = this.valorvisor;
                novocalculo.valoranterior = this.valoranterior;

                novocalculo.operacao = this.operaxao;

                operaxao = "/";
                txthistorico.Text += "/" + txtvisor.Text;
                valoranterior = Convert.ToDouble(txtvisor.Text);
                botaoigual = true;
            }
        }
        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (primeiraoperacao)
            {
                valoranterior = Convert.ToDouble(txtvisor.Text);

                if (botaoigual == false)
                {
                    txthistorico.Text += txtvisor.Text;
                }

                txtvisor.Clear();
                operaxao = "-";
                primeiraoperacao = false;
            }
            else
            {
                valorvisor = Convert.ToDouble(txtvisor.Text);

                txtvisor.Text += operaxao + txtvisor.Text;
                //txtvisor.Text = Convert.ToString(valoranterior - valorvisor);
                // txtvisor.Text = Convert.ToString(calculo());
                objetocalculo novocalculo = new objetocalculo();

                novocalculo.valorvisor = this.valorvisor;
                novocalculo.valoranterior = this.valoranterior;

                novocalculo.operacao = this.operaxao;

                operaxao = "-";
                txthistorico.Text += "-" + txtvisor.Text;
                valoranterior = Convert.ToDouble(txtvisor.Text);
                botaoigual = true;
            }
        }
        private void btnvezes_Click(object sender, EventArgs e)
        {
            if (primeiraoperacao)
            {
                valoranterior = Convert.ToDouble(txtvisor.Text);

                if (botaoigual == false)
                {
                    txthistorico.Text += txtvisor.Text;
                }

                txtvisor.Clear();
                operaxao = "*";
                primeiraoperacao = false;
            }
            else
            {
                valorvisor = Convert.ToDouble(txtvisor.Text);

                txtvisor.Text += operaxao + txtvisor.Text;
                txtvisor.Text = Convert.ToString(valoranterior - valorvisor);

                operaxao = "*";
                txthistorico.Text += "*" + txtvisor.Text;
                valoranterior = Convert.ToDouble(txtvisor.Text);
                botaoigual = true;
            }
        }
        private void btnraiz_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega o valor atual do visor
                double valor = Convert.ToDouble(txtvisor.Text);

                // Calcula a raiz quadrada usando a classe Math do C#
                double resultado = Math.Sqrt(valor);

                // Atualiza o histórico e o visor
                txthistorico.Text += $"√({valor}) = {resultado}";
                txtvisor.Text = resultado.ToString();

                // Prepara o estado para a próxima operação
                botaoigual = true;
                primeiraoperacao = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira um número válido para calcular a raiz.");
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            valorvisor = Convert.ToDouble(txtvisor.Text);
            txthistorico.Text += operaxao + txtvisor.Text;
            // txtvisor.Text = Convert.ToString(calculo());
            objetocalculo novocalculo = new objetocalculo();

            novocalculo.valorvisor = this.valorvisor;
            novocalculo.valoranterior = this.valoranterior;

            novocalculo.operacao = this.operaxao;

            txthistorico.Text += "=" + txtvisor.Text;
            valoranterior = Convert.ToDouble(txtvisor.Text);

            botaoigual = true;
            primeiraoperacao = true;
        }

        /*
        public double calculo()
        {
            switch (operaxao)
            {
                case "+":
                    valoranterior = valoranterior + valorvisor;
                    break;

                case "-":
                    valoranterior = valoranterior - valorvisor;
                    break;
                case "*":
                    valoranterior = valoranterior * valorvisor;
                    break;
                case "/":
                    valoranterior = valoranterior / valorvisor;
                    break;

                default:
                    break;
            }

            return valoranterior;
        }*/

             
        }
    }

