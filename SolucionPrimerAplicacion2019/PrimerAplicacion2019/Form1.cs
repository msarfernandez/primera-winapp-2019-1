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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovedades_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenide");
        }

        private void btnIrVentanaDos_Click(object sender, EventArgs e)
        {
            frmSegundaVentana ventanaDos = new frmSegundaVentana();
            ventanaDos.ShowDialog();
        }
    }
}
