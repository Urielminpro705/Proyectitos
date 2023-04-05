using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //area y un perimetro de alguna figura geometrica
            //El usuario ingresa los valor
            //Lado por lado - cuadrado
            //Base por altura - rectangulo
            //Sumar todos los lados, base + altura * 2
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
            Console.WriteLine("El area es: " + area);
            Console.WriteLine("El perimetro es: " + perimetro);
            Console.WriteLine("Gracias por participar");
            /*Como podemos hacer la representacion de variables
             * en las salidas a consola, diferentes ti[ps de concatenacion
             */
            int laVariable = 4;
            //Console.WriteLine("La cadena de texto " + laVariable);
            Console.WriteLine("La base es {0}, y la altura es {1}",laBase, laAltura);
            Console.WriteLine($"Area es {laBase*laAltura} y el perimetro es{laBase*2+laAltura*2}");

            //Vamos a usar una constante para el circulo
            //decimal PI = (decimal)Math.PI;
            Console.WriteLine("Ingresa el valor del radio para realizar la operacion");
            int elRadio = int.Parse(Console.ReadLine());
            double elResultadoDelCirculo = elRadio * Math.PI;
            Console.WriteLine("El resultado es: " + elResultadoDelCirculo);
            double elUsoDeMath = Math.Pow(elRadio, 2) * Math.PI;
            Console.WriteLine("El uso de Math es {0}",elUsoDeMath);

            //
            /*
             * 
             * Realizar un proyecto nuevo donde se realice:
             * area y perimetro de un circulo
             * area y perimetro de un triangulo equilatero, isoceles y escaleno
             * Volumen de un cubo
             * Volumen de un cilindro
             * Se debe de imprimir el resultado y los datos ingresados para cada uno de los elementos
             * Subir un video desde la compu o celular con la demostracion de ejecucion
             * Nombre: Proyectico2
             */
        }
    }
}
