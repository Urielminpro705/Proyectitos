using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] meses=new String[12];
            meses[0] = "Un chicle";
            meses[1] = "Nada";
            meses[2] = "Un Mazapan";
            meses[3] = "Una Picafresa";
            meses[4] = "Un Carlos V";
            meses[5] = "Un Pastel";
            meses[6] = "Un peso";
            meses[7] = "Un carro";
            meses[8] = "Unos Boletos de avion";
            meses[9] = "Un terrenator";
            meses[10] = "Un lego";
            meses[11] = "Una casa";

            int i = 0;
            int n=0;
            Console.WriteLine("--Escoge un numero del 1 al 12 para ganar un premio sorpresa");
            do
            {
                do
                {
                    Console.WriteLine("Ingrese la posicion que quiera ver del 1 al 12");

                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        i++;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("El numero es demasiado grande,vuelve a intentar");
                        i = 0;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Las letras no son validas, vuelve a intentar");
                        i = 0;
                    }


;
                } while (i < 1);

                
                    i = 0;
                    if (n > 0 && n <= 12)
                    {
                        Console.WriteLine($"Tu premio es {meses[n - 1]}");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("El valor no es valido, vuelve a intentarlo");
                    }

            } while (i < 1) ;
            
        }
    }
}
