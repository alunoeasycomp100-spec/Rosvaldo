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
    public partial class frmvisualizadorimagem : Form
    {
        public frmvisualizadorimagem()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void pblmagens_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pblmagens.Image = null; // limpa a imagemdo picturebox pblmagens
        }

        private void btnmostrarimagem_Click(object sender, EventArgs e)
        {
            if (ofdlmagens.ShowDialog() == DialogResult.OK)
            { // seo radiobutton stretch estiver marcado
                pblmagens.Load(ofdlmagens.FileName);
                btnlimparimagem.Enabled = true; //a propiedade sizemode da imagem bo picturebox ficara strechimage
            }
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true) ; // seo radiobutton normal estiver marcado
            {
                pblmagens.SizeMode = PictureBoxSizeMode.StretchImage; // a propiedade sizemode da imagem no picturebox ficara normal
            }
               
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnormal.Checked == true) ;
            {
                pblmagens.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        
    }
}
