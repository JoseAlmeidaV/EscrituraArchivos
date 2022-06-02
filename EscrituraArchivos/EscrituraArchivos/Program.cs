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
        internal class Persona
        {
            public string nombre, apellidos, estudios;
            public int edad;
            
            public Persona(string nombre, string apellido, string estudios, int edad)
            {
                this.nombre = nombre;
                this.apellidos = apellido;
                this.estudios = estudios;
                this.edad = edad;
            }
            public void Resultados()
            {
                Console.WriteLine("DATOS ESCRITOS EN EL DOCUMENTO DE TEXTO");
                Console.WriteLine("nombre: " + nombre);
                Console.WriteLine("Apellido: " + apellidos);
                Console.WriteLine("Estudios: " + estudios);
                Console.WriteLine("Edad: " + edad);
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            Console.Write("Coloque el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Coloque el apellido parterno: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Coloque su grado de estudio: ");
            string estudios = Console.ReadLine();
            Console.Write("Coloque su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Persona P1 = new Persona(nombre, apellido, estudios, edad);
            P1.Resultados();
            sw.Close(); // siempre se debe cerrar el archivo
            Console.ReadKey();
        }
    }
}
