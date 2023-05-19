using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySampoControlesBasicos
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void txtEscribir_TextChanged(object sender, EventArgs e)
        {
            lblCopiado.Text = txtEscribir.Text;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (optRojo.Checked ==true)
            {
                lblCopiado.ForeColor = Color.Red;
                txtEscribir.ForeColor = Color.Red;
            }



            if (optAzul.Checked ==true)
            {
                lblCopiado.ForeColor = Color.Blue;
                txtEscribir.ForeColor = Color.Blue;
            }
           
        }

        private void chkPicante_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPicante.Checked ==true) 
            {
                lblCopiado.Text = "picante";
            
            }
        }

        private void chkMayo_CheckedChanged(object sender, EventArgs e)
        {
            if( chkMayo.Checked ==true) 
            { 
              lblCopiado.Text = "Mayonesa";
            }
        }

        private void chkKetchup_CheckedChanged(object sender, EventArgs e)
        {
         if(!chkKetchup.Checked == true) 
            {
                lblCopiado.Text = "Ketchup";
            }
        }
    }
}
