using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos,segundos;
            Console.Write("Ingresa el valor de horas: ");
            horas = int.Parse(Console.ReadLine());
            minutos = horas * 60;
            segundos = horas * 3600;
            Console.WriteLine("Valor de minutos: " + minutos);
            Console.WriteLine();
            Console.WriteLine("Valor de minutos: " + segundos);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
