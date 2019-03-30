using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace WinForm
{
    public partial class frmEjemploGrilla : Form
    {
        //esto es un atributo privado propio de esta ventana.
        private List<Animal> listadoAnimales = new List<Animal>();

        //Este es el constructor de esta ventana. Vino por default.
        public frmEjemploGrilla()
        {
            InitializeComponent();
        }

        private void frmEjemploGrilla_Load(object sender, EventArgs e)
        {
            //carga manual de items uno por uno.
            cboColor.Items.Add("Pardo");
            cboColor.Items.Add("Azul noche");
            cboColor.Items.Add("Salmón");
            cboColor.Items.Add("Negro Montés");

            dgvAnimales.DataSource = listadoAnimales;

            //agregar al combo en una sola linea declarando un array de string antes.
            //sigue siendo completamente manual.
            //string[] animals2 = new string[] { "deer", "moose", "boars" };
            //cboColor.Items.AddRange(animals2);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || cboColor.SelectedIndex < 0)
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            Animal nuevo = new Animal(txtNombre.Text.Trim(), txtApellido.Text.Trim(), cboColor.SelectedItem.ToString());
            listadoAnimales.Add(nuevo);
            refrescarGrilla();

        }

        private void refrescarGrilla()
        {
            dgvAnimales.DataSource = null;
            dgvAnimales.DataSource = listadoAnimales;
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            Gato gato = new Gato(txtNombre.Text.Trim());
            gato.Color = cboColor.SelectedItem.ToString();
            gato.Origen = "La calle";
            listadoAnimales.Add(gato);
            refrescarGrilla();
        }
    }
}
