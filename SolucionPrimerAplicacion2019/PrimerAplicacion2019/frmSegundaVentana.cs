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
    public partial class frmSegundaVentana : Form
    {
        public frmSegundaVentana()
        {
            InitializeComponent();
        }

        private void frmSegundaVentana_Load(object sender, EventArgs e)
        {
            //te lo juro
        }

        private void frmSegundaVentana_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("hasta luego...");
        }

        private void frmSegundaVentana_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiciste click en la ventana");
        }
    }
}
