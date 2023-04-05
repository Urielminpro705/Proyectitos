using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, opcion2, opcion3;
            opcion = menu();
            switch (opcion)
            {
                case 1:
                    Basico l=new Basico();
                    l.Leer();
                    l.imprimir();
                    break;

                case 2:
                    opcion2= menu2();
                    switch (opcion2)
                    {
                        case 1:
                            opcion3 = menu3();
                            switch (opcion3)
                            {
                                case 1:
                                    Fisico l2 = new Fisico();
                                    l2.Leer();
                                    l2.imprimir();
                                    break;

                                case 2:
                                    Premium l3=new Premium();
                                    l3.Leer();
                                    l3.imprimir();
                                    break;

                                default:
                                    Console.WriteLine("El valor no es valido");
                                    break;
                            }
                            break;

                        case 2:
                            Digital l4= new Digital();
                            l4.Leer();
                            l4.imprimir();
                            break;

                        default:
                            Console.WriteLine("El valor no es valido");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("El valor no es valido");
                    break;
            }
        }

        public static int menu()
        {
            int opcion;
            Console.WriteLine("Escoge una opcion");
            Console.WriteLine("1) Informacion basica");
            Console.WriteLine("2) Informacion detallada");
            opcion=int.Parse(Console.ReadLine());
            return opcion;
        }

        public static int menu2()
        {
            int opcion;
            Console.WriteLine("Escoge una opcion");
            Console.WriteLine("1) El libro es fisico");
            Console.WriteLine("2) El libro es digital");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public static int menu3()
        {
            int opcion;
            Console.WriteLine("Escoge una opcion");
            Console.WriteLine("1) Calidad basica");
            Console.WriteLine("2) Calidad premium");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
