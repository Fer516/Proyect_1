using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resSuma;
            int resResta;
            int resMulti;
            int resDiv;

            Console.WriteLine("Ingresa el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resSuma = num1 + num2;
            resResta = num1 - num2;
            resMulti = num1 * num2;
            resDiv = num1 / num2;

            Console.WriteLine("Suma: " + resSuma);
            Console.WriteLine("Resta: " + resResta);
            Console.WriteLine("Multiplicacion: " + resMulti);
            Console.WriteLine("Division: " + resDiv);
            Console.ReadKey();
        }
    }
}
