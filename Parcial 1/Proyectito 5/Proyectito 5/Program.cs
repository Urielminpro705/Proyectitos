using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Introduce un numero");
            n=double.Parse(Console.ReadLine());
            tabla(n);
        }

        public static void tabla(double n)
        {
            for (double i=1; i<=12; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n*i);
            }
        }
    }
}
