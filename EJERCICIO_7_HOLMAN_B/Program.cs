using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7_HOLMAN_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona[] per=new persona[3];

            per[0] = new profesor("Juan\n");
            per[1] = new Estudiante("Sara\n");
            per[2] = new Estudiante("Carlos\n");

            foreach(persona p1 in per)
            {
                Console.WriteLine(p1.ToString());
            }
            foreach ( persona p in per)
            {
                if(p is Estudiante)
                {
                    ((Estudiante)p).estudiar();
                }
                else
                {
                    ((profesor)p).explique();
                }
            }
            Console.ReadKey();

            
        }
    }
}
