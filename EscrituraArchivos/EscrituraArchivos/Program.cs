using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            // si el archivo no existe lo creara
            // si ya existe, esbira en el 

            string[] Lineas =
            {
                "esta es la informacion de la primera linea ",
                "es es la segunda linea",
                "fin del texto"
            };
            foreach(string linea in Lineas)
            {
                sw.WriteLine(linea);

            }
            sw.Close(); // siempre se debe cerrar el archivo
            Console.ReadKey();
        }
    }
}
