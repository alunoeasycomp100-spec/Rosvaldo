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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            lblMensagens.Text = "Primeiro Aplicatvo em C#"; // A lblMensagem exibe um texto
            lblMensagens.ForeColor = Color.RoyalBlue; // E a cor do mesmo é definida como azul royal

        }

        private void btnPropiedadesCheckBox_Click(object sender, EventArgs e)
        {
            frmPropiedadeCheckBox propriedades = new frmPropiedadeCheckBox(); // instanciando o formulário
                propriedades.ShowDialog(); // o formulário é exibido através do método ShowDialog
        }

        private void btnimagens_Click(object sender, EventArgs e)
        {
            frmvisualizadorimagem visualizadorimagem = new frmvisualizadorimagem(); // instanciando o formulário
            visualizadorimagem.ShowDialog(); // o formulário é exibido através do método ShowDialog
        }
    }
}
