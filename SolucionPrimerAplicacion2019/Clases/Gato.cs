using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gato : Animal
    {
        public Gato(string nombre) {
            Nombre = nombre;
        }

        public override string comunicarse()
        {
            return "MIAUUUU MIAUUUUU....";
        }
    }
}
