using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veamos como capturar errores ...");
            Console.WriteLine("Primero, esperemos un numero para hacer algo ...");
            int elNumero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bueno, multipliquemos el {elNumero} por si mismo para ver " + $"el resultado {elNumero*elNumero}");
            Console.WriteLine("Bueno el numero es: " + elNumero + "y lo vamos a multiplicar por si mismo y el resultado es " + elNumero + elNumero);
            
            //int elPokemon=int.Parse(Console.ReadLine());
            int elPokemon;
            do
            {
                Console.WriteLine("Selecciona un Pokemon del 1 al 12: ");
                try
                {
                    elPokemon = int.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Algo  no junciona, usaron un numero muy grande, mejor intente otra vez");
                    elPokemon = 0;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Algo  no junciona, escribieron texto, mejor intente otra vez");
                    elPokemon = 0;
                }
                catch (Exception e)//el error generico
                {
                    Console.WriteLine(e.Message);//indica el mensaje de error
                    Console.WriteLine("El mensaje anterior indica el error cometido...");
                    elPokemon = 0;
                }
                Console.WriteLine(laOtraFuncion(elPokemon));
            } while (elPokemon<1 || elPokemon>12);
            
            
            /*
             * Para poder concatenar, se usa el +
             * o bien $"el texto {laVariable} y seguir con el texto
             */
           
        }

        static string laOtraFuncion(int elNumero)
        {
            switch (elNumero)
            {
                case 1:
                    return "Pika";
                    break;

                case 2:
                    return "Miaw";
                    break;

                case 3:
                    return "Sombrilla";
                    break;

                case 4:
                    return "Vela";
                    break;

                case 5:
                    return "El de agua";
                    break;

                case 6:
                    return "Amo a calmarno";
                    break;

                case 7:
                    return "Fredo ya calmate";
                    break;

                case 8:
                    return "Gravitania";
                    break;

                case 9:
                    return "La mona china que se acuerden del nombre";
                    break;

                case 10:
                    return "Andan un poco curiosos";
                    break;

                case 11:
                    return "Vaporel";
                    break;

                case 12:
                    return "El otro del trio galaxia";
                    break;

                default:
                    return "Vuelve a introducir un numero";
                }
        }
    }
}
