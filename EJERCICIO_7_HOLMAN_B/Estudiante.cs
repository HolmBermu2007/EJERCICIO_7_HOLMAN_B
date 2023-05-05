using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7_HOLMAN_B
{
    internal class Estudiante : persona
    {
        public Estudiante(string nombre)
        {
            this.Nombre = nombre;
        }
        public void estudiar()
        {
            Console.WriteLine("Estudiando\n");
        }
        
    }
}
