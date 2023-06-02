using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nº7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area;
            int perimetro;
            int altura;
            int Base;


            Console.WriteLine("ingre altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese Base");
            Base = int.Parse(Console.ReadLine());

            area = Base * altura;
            perimetro = 2*(altura + Base);

            Console.WriteLine("El area es : " + area);
            Console.WriteLine("El perimetro es: " + perimetro);

            Console.ReadKey();

        }
    }
}
