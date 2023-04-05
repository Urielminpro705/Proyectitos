using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Act_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Coche c = new Coche();
                        c.asignar();
                        imprimir(c);
                        break;

                    case 2:
                        Motocicletas m = new Motocicletas();
                        m.asignar();
                        imprimir(m);
                        break;

                    case 3:
                        Bicicleta b = new Bicicleta();
                        b.asignar();
                        imprimir(b);
                        break;

                    default:
                        Console.WriteLine("Valor no valido");
                        break;
                }
            } while (opcion != 4);
        }

        public static void imprimir(Vehiculos c)
        {           
                Console.WriteLine(c.getCapacidad());
                Console.WriteLine(c.getLlantas());
                Console.WriteLine(c.getPuertas());
                Console.WriteLine(c.getventanas());
        }
        public static int menu()
        {
            int opcion;
            Console.WriteLine("--Escoge un vehiculo para ver sus caracteristicas--");
            Console.WriteLine("1) Coche");
            Console.WriteLine("2) Motocicletas");
            Console.WriteLine("3) Bicicleta");
            Console.WriteLine("4) Salir");
            opcion=int.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
