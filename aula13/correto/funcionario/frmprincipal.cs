namespace funcionario
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if(cbcargo.Text == "Assistente Administrativo")
            {
                Administrativo funcionario = new Administrativo();
                    
                   funcionario.salvar (txtnome.Text, cbcargo.Text, Convert.ToDecimal(txtsalario.Text));

                txtfuncionario.AppendText(funcionario.retornarnome() + "\t");
                txtfuncionario.AppendText(funcionario.retornarcargo() + "\t");
                txtfuncionario.AppendText(funcionario.retornarsalario() + "\t");
                
            }
            else
            {
                designer funcionario = new designer();

                funcionario.salvar(txtnome.Text, cbcargo.Text, Convert.ToDecimal(txtsalario.Text));

                txtfuncionario.AppendText(funcionario.retornarnome() + "\t");
                txtfuncionario.AppendText(funcionario.retornarcargo() + "\t");
                txtfuncionario.AppendText(funcionario.retornarsalario() + "\t");


            }


        }
    }
}
