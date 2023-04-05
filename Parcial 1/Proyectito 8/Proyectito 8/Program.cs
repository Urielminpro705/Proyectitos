using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a crear una computadora base:");
            LasComputadoras computadorsita1 = new LasComputadoras();
            Console.WriteLine("Las caracteristicas de la computadora base es:");
            Console.WriteLine(computadorsita1);
            Console.WriteLine(computadorsita1.getCaracIniciales());
            LasComputadoras computadoras2 = new LasComputadoras("HP", "Intel i5-11500K", 8, 256);
            Console.WriteLine("Las caracteristicas de la computadora son: ");
            Console.WriteLine(computadoras2.getCaracIniciales());
            Console.WriteLine("Establecemos las caracteristicas opcionales de ambas computadoras");
            computadorsita1.setOpcionales("Negro", true, true);
            computadoras2.setOpcionales("Gris", true, false);
            Console.WriteLine("Vemos las variaciones en ambas: ");
            Console.WriteLine("La computadora 1: ");
            Console.WriteLine(computadorsita1.GetOpcionales());
            Console.WriteLine("La computadora 2: ");
            Console.WriteLine(computadoras2.GetOpcionales());
        }
    }
}

    
