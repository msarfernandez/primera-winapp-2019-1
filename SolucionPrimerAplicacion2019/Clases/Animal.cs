using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Animal
    {
        public string Nombre { get; set; }
        private string apellido;

        public Animal(string apellido)
        {
            this.apellido = apellido;
        }
        public Animal() { }

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
