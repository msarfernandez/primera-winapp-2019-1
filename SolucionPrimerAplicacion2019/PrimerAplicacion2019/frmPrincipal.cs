using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerAplicacion2019
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuVentanaUno_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
