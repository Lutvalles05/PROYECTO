using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_º_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area;
            int perimetro;
            int lado;
            int lado2;


            Console.WriteLine("ingrese lado");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lado2");
            lado2 = int.Parse(Console.ReadLine());

            area = lado * lado2 / 2;
            perimetro = 2 * lado + 2 * lado2;

            Console.WriteLine("muestre area : " + area );
            
            Console.WriteLine("muestre perimetro : " + perimetro);

            Console.ReadLine();

            




            


            

        }
    }
}
