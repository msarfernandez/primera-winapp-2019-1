using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Animal
    {
        //atributos-propiedades (2 en 1)
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Origen { get; set; }

        //atributo a secas, es privado!
        private string apellido;

        //constructores
        public Animal(string apellido)
        {
            this.apellido = apellido;
        }
        //constructor vacío, te crea la instancia vacía... obvio no?
        public Animal() { }

        public Animal(string nombre, string apellido, string color)
        {
            Nombre = nombre;
            this.apellido = apellido;
            Color = color;
            Origen = "Incierto";
        }

        //hasta acá constructores

        public string nombreCompleto()
        {
            return Nombre + " " + apellido;
        }

        public virtual string comunicarse()
        {
            return "GRRRRRRRR...";
        }

        public string desplazarse()
        {
            return "deslizando...";
        }

    }
}
