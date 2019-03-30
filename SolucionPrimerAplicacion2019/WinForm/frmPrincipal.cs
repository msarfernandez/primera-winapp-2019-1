using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjemploPolimorfismo_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnEjemploGrilla_Click(object sender, EventArgs e)
        {
            frmEjemploGrilla grilla = new frmEjemploGrilla();
            grilla.MdiParent = this;
            grilla.Show();
        }
    }
}
