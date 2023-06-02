using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nº2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peso;
            int dolar;
            int euro;

            Console.WriteLine("ingrese la cantidad de pesos ");
            peso = int.Parse(Console.ReadLine());


            euro =  peso/ 227;
            dolar =  peso/208;


            Console.Write("tu cantidad en euro es" + dolar);
            Console.WriteLine();
            Console.Write("tu cantidad en dolar es " + euro) ;
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
