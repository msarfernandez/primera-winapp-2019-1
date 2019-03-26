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

namespace PrimerAplicacion2019
{
    public partial class frmAnimales : Form
    {
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {

                IList<Animal> animales = new List<Animal>();

                Animal maxi;
                Animal juanGonzalez = new Animal();
                juanGonzalez.Nombre = "Juan Gonzalez";

                maxi = new Gato("Maxi");
                //MessageBox.Show(maxi.Nombre);

                Animal franciscoCrespo = new Animal();

                Gato dangelo = new Gato("Martin");
                Gato tidele = new Gato("alejandro");

                Perro ocampo = new Perro();
                Perro deLage = new Perro();
                Perro muniz;


                dangelo = (Gato)maxi;
                MessageBox.Show(dangelo.Nombre);


                animales.Add(maxi);
                animales.Add(dangelo);
                animales.Add(tidele);
                animales.Add(ocampo);
                animales.Add(deLage);
                animales.Add(juanGonzalez);
                animales.Add(franciscoCrespo);

                foreach (var animal in animales)
                {
                    MessageBox.Show(animal.comunicarse());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
