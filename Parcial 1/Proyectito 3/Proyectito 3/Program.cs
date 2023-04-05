using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0, i=0;
            do
            {
                Random aleatorio = new Random();
                int dado=aleatorio.Next(1, 6);
                Console.WriteLine("Que numero crees que va a salir del 1 al 6");
                int n=int.Parse(Console.ReadLine());
                if (dado == n)
                {
                    Console.WriteLine("¡¡¡Lo lograste!!!");
                    j++;
                }
                else
                {
                    if (n > 6 || n < 1)
                    {
                        Console.WriteLine("Valor no valido. Vuelve a intentarlo");
                    }
                    else
                    {
                        if (dado < n || dado > n)
                        {
                            Console.WriteLine("Salio {0}. Vuelve a intentarlo", dado);
                            i++;
                        }

                    }
                }

                

            } while (j<1);
            Console.WriteLine("El numero de intentos fallidos fue: " + i);
        }
    }
}
