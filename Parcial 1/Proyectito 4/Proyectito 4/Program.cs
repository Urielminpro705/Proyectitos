using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double a, b, suma, resta, multiplicacion, division;
            do
            {
                do
                {
                    Console.WriteLine("Introduce el primer numero (que no sea 0)");
                    a = double.Parse(Console.ReadLine());
                    if (a < 0 || a > 0)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Numero no valido, vuelve a intentarlo\n");
                        i = 0;
                    }
                } while (i < 1);
                do
                {
                    Console.WriteLine("Introduce el segundo numero (que no sea 0)");
                    b = double.Parse(Console.ReadLine());
                    if (b < 0 || b > 0)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Numero no valido, vuelve a intentarlo\n");
                        i = 1;
                    }
                } while (i <= 1);
                if(a>b || a < b)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Los numeros no pueden ser iguales, ingresalo otra vez\n");
                    i = 0;
                }
            } while (i <= 2);
            suma=Suma(a, b);
            resta = Resta(a, b);
            multiplicacion = Multiplicacion(a, b);
            division = Division(a, b);

            Resultados(a, b, suma, resta, multiplicacion,division);

        }

        public static double Suma(double a, double b)
        {
            double suma;
            suma = a + b;
            return suma;
        }

        public static double Resta(double a, double b)
        {
            double resta;
            resta = a - b;
            return resta;
        }

        public static double Multiplicacion(double a, double b)
        {
            double multiplicacion;
            multiplicacion = a * b;
            return multiplicacion;
        }

        public static double Division(double a, double b)
        {
            double division;
            division = a / b;
            return division;
        }

        public static void Resultados(double a, double b, double suma, double resta, double multiplicacion, double division)
        {
            Console.WriteLine("La suma es: " + a + " + " + b + " = " + suma);
            Console.WriteLine("La resta es: {0} - {1} = {2}",a,b,resta );
            Console.WriteLine("La multiplicacion es: {0} * {1} = {2}",a,b,multiplicacion);
            Console.WriteLine("La division es: {0} / {1} = {2}",a,b,division);
        }
    }
}
