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
    public partial class Form1 : Form
    {
        private string unAtributoDelForm;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string valor)
        {
            InitializeComponent();
            unAtributoDelForm = valor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = unAtributoDelForm;
            unMetodo();
        }

        private void unMetodo()
        {
            try
            {
                Animal ani1 = new Animal("Sar Fernandez");
                ani1.Nombre = "Bella";
                Gato gato1 = new Gato("Pepe");
                Perro perro1 = new Perro();
                perro1.Nombre = "Pompa";

                //MessageBox.Show(ani1.nombreCompleto());

                List<Animal> animales = new List<Animal>();
                animales.Add(ani1);
                animales.Add(gato1);
                animales.Add(perro1);

                List<Gato> gatos = new List<Gato>();
                gatos.Add(gato1);
                gatos.Add(new Gato("Orestes"));
                Animal ani2 = new Gato("Jack Black");
                gatos.Add((Gato)ani2);

                animales.Add(ani2);

                int contador = 0;
                foreach (var animal in animales)
                {
                    MessageBox.Show(animal.nombreCompleto() + " saludo: " + animal.comunicarse());
                    contador++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            unMetodo();
        }
    }
}
