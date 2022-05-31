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
            Console.WriteLine("escriba un nombre: ");
            sw.WriteLine(Console.ReadLine());
            


            sw.Close(); // siempre se debe cerrar el archivo
            Console.ReadKey();
        }
    }
}
