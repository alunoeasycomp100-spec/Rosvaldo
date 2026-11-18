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
            btnPropiedadesCheckBox.Enabled = true; //habilita o botao btnpropiedade
            btnimagens.Enabled = true; // habilita o botao btnimagem
            btntabuada.Enabled = true; // habilita o botao btntabuada

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

        private void btntabuada_Click(object sender, EventArgs e)
        {
           frmtabuada tabuada = new frmtabuada(); // instanciando o formulario frmtabuada
            tabuada.ShowDialog(); // o formuario é exibido atraves do metodo showdialog.
        }
    }
}
