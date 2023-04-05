using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_2
{
    internal class Basico:Libros
    {
        public override void Leer()
        {
            Console.WriteLine("Ingresa el titulo");
            this.titulo = Console.ReadLine();
            Console.WriteLine("Ingresa el autor");
            this.autor = Console.ReadLine();
            Console.WriteLine("Ingresa el genero");
            this.genero = Console.ReadLine();
        }
            

        public override void imprimir()
        {
            Console.WriteLine("\nTitulo: "+titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Genero: " + genero);
        }
    }
}
