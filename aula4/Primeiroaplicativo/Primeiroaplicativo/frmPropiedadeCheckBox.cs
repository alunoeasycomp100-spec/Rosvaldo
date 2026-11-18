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
    public partial class frmPropiedadeCheckBox : Form
    {
        public frmPropiedadeCheckBox()
        {
            InitializeComponent();
        }

        // evento que verifica se o Chrckbox está marcado ou desmarcado 
        
                

        private void chkPessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true)
            {
                pnlPessoaFísica.Visible = true;
            }
            else
                pnlPessoaFísica.Visible = false;
        }

        private void chkPessoajurica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoajuridica.Checked == true)
            {
                pnlPessoaJuridica.Visible = true;
            }
            else
                pnlPessoaJuridica.Visible = false;
        }

    }
}
