using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es la base?");
            int laBase;
            string laCadenaDeLaBase;
            laCadenaDeLaBase = Console.ReadLine();
            laBase = int.Parse(laCadenaDeLaBase);
            Console.WriteLine("Cual es la altura?");
            int laAltura = int.Parse(Console.ReadLine());
            double area, perimetro;
            perimetro = (laBase * 2) + (laAltura * 2);
            area = laBase * laAltura;
            Console.WriteLine("La base es {0} y la altura es {1}",laBase,laAltura);
            Console.WriteLine("El area es: " + area);
            Console.WriteLine("El perimetro es: " + perimetro);
            Console.WriteLine("Gracias por participar");
        }
    }
}
