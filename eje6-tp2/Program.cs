using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nº6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int perimetro;
            int lado;
            int lado2;
            int lado3;
            int lado4;
            int lado5;
            int lado6;



            Console.WriteLine("ingrese lado ");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lado2");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lado3");
            lado3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lado4");
            lado4=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lado5");
            lado5 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lado6");
            lado6 = int.Parse(Console.ReadLine());

            perimetro = lado + lado2 + lado3 + lado4 + lado5 + lado6;
            
            Console.WriteLine("el perimetro es:" + perimetro);
            Console.ReadLine();



        }
    }
}
