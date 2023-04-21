using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Leer_archivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeerArchivo a=new LeerArchivo();
            a.cantidadRenglones();
        }

        class LeerArchivo
        {
            StreamReader archivo = null;
            int contador = 0;
            String renglon;

            public LeerArchivo()
            {
                Console.WriteLine("---Texto---");
                archivo = new StreamReader(@"C:\Uriel\Universidad\Segundo semestre\Segundo parcial\Programacion orientada a entornos visuales\Programas\2P-Leer-archivo\2P-Leer-archivo\TheBestSongEver.txt");
                while ((renglon = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(renglon);
                    contador++;
                }
            }

            public void cantidadRenglones()
            {
                Console.WriteLine("\nEl texto tiene {0} renglones", contador);
            }

            ~LeerArchivo()
            {
                archivo.Close();
            }
        }
    }
}
