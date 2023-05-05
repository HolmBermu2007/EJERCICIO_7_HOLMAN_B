using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7_HOLMAN_B
{
    internal class persona
    {
        string nombre;

        public persona(string nombre)
        {
            this.Nombre = nombre;
        }
        public persona()
        {

        }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return " "+ nombre ;
        }
    }
}
