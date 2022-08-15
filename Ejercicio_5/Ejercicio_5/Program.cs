using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            int peso;
            int estatura;
            int tipo_de_sangre;

            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine(); 

            Console.Write("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su peso: ");
            peso = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura: ");
            estatura = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su tipo de sangre: ");
            tipo_de_sangre = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre: " + nombre + "Su edad es de: " + edad + "años"+"Tu peso es de:"+peso+"Su estatura es de: "+estatura+"Su tipo de sangre es: "+tipo_de_sangre);
            Console.ReadLine();
        }
    }
}
