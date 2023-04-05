using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_9v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Celular cel2 = new Celular();

            int i = 0;
            do
            {
                int opcion;
                opcion = pedirInformacion();
                if (opcion > 0 && opcion < 5)
                {
                    Celular cel1 = new Celular();
                    switch (opcion)
                    {
                        case 1:
                            
                            Console.WriteLine("--Caracteristicas basicas--");
                            Console.WriteLine(cel1.getTelefono() + "\n");
                            
                            break;
                        case 2:
                            Console.WriteLine("--Caracteristicas Intermedias--");
                            cel1.setIntermedio("Procesador no tan mediocre", true, 128, "Telcel");
                            Console.WriteLine(cel2.getTelefono() + "\n");
                            break;

                        case 3:
                            Console.WriteLine("Introduce el gpu del telefono:");
                            String gpu = Console.ReadLine();
                            Console.WriteLine("Introduce si tiene doble sim o no (false o true):");
                            Boolean sim = Boolean.Parse(Console.ReadLine());
                            Console.WriteLine("Introduce la capacidad del telefono:");
                            int cap = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduce la compañia del telefono:");
                            String com = Console.ReadLine();
                            cel1.setOpcional(gpu, sim, cap, com);
                            Console.WriteLine("\n--Caracteristicas Personalizadas--");
                            Console.WriteLine(cel1.getTelefono() + "\n");

                            break;

                        case 4:
                            i++;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("El valor no es valido");
                    i = 0;
                }



            } while (i < 1);

        }

        public static int pedirInformacion()
        {
            int opcion;
            Console.WriteLine("Escoge una de las opciones:");
            Console.WriteLine("1) Opcion basica");
            Console.WriteLine("2) Opcion intermedia");
            Console.WriteLine("3) Personalizable");
            Console.WriteLine("4) Salir");
            return opcion = int.Parse(Console.ReadLine());
        }
    }
}
