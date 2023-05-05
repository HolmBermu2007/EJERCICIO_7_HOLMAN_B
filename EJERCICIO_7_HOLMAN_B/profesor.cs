using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7_HOLMAN_B
{
    internal class profesor: persona
    {
        public profesor(string nombre)
        {
            this.Nombre = nombre;
        }
        public void explique()
        {
            Console.WriteLine(" Explicando\n");
        }

    }
}
