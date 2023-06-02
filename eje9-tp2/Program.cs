using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nº9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double  ventas,sueldo;

            Console.WriteLine("ingrese su sueldo :");
            sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de ventas :");
            ventas = double.Parse(Console.ReadLine());

            Console.WriteLine("La comision es : " + (sueldo * 0.10));
            Console.ReadLine();


            Console.ReadKey();

        }
    }
}
