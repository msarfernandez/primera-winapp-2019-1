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
        private BindingList<Animal> listaBindeable;

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

            //MSF-20190331: desactivo lo que vimos el viernes.
            //dgvAnimales.DataSource = listadoAnimales;

            //agrego la nueva manera de darle datos a la grilla
            //es un tipo de colección, vean que se llama "BindingList". La variable la creé
            //como atributo privado del Form para que esté disponible en todos los eventos. Pero le agregué
            //la instancia recién aquí.
            listaBindeable = new BindingList<Animal>(listadoAnimales);
            dgvAnimales.DataSource = listaBindeable;

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
            //dgvAnimales.DataSource = null;
            //dgvAnimales.DataSource = listadoAnimales;
            //En el refressh sacamos lo que estaba antes y hacemos esto nuevo:
            //En los botones, la parte de agregar a la lista quedó igual.
            listaBindeable.ResetBindings();

            //la única diferencia que tenemos es que ahora tenemos 1 colección de tipo Lista y una de tipo
            //lista "bindeable" 
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            Gato gato = new Gato(txtNombre.Text.Trim());
            gato.Color = cboColor.SelectedItem.ToString();
            gato.Origen = "La calle";
            listadoAnimales.Add(gato);
            refrescarGrilla();
        }

        private void btnMostrarSeleccionado_Click(object sender, EventArgs e)
        {
            //Creo una variable Object para guardar el objeto seleccionado.
            //Recordemos que la grilla recibe cualquier cosa y la interpreta internamente, por eso es dinámica.
            //Pero luego, cuando te devuelve, te da lo mínimo que sabe conocer, que es un object a secas
            //y es lo que la hace genérica.
            Object objetoSeleccionado;
            //ahora guardo adentro de esa variable el objeto seleccionado en la grilla:
            //la grilla se comopone de rows (filas) y cada fila de cells (celdas). En este caso vamos a
            //apuntar directamente a la fila. CurrentRow, es decir, Fila Actual (la seleccionada).
            //Y de esa fila, quiero "el item bindeado", o sea, enlazado. Lo que me va a devolver ese "Object"
            //del que hablábamos antes.
            objetoSeleccionado = dgvAnimales.CurrentRow.DataBoundItem;

            //Ahora, ese objeto OBJECT, yo sé que es un animal, y lo quiero tratar como tal.
            //Entonces lo voy a guardar en una variable de tipo animal, pero lo voy a tener que castear.
            Animal animalSeleccionado = (Animal)objetoSeleccionado;

            //Ahora tengo disponible al animal como tal para poder usarlo:
            MessageBox.Show(animalSeleccionado.Nombre + ", " + animalSeleccionado.Color);
            
        }
    }
}
