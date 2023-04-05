using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_2
{
    sealed class Digital:Comunes
    {
        override public void Leer()
        {
            Console.WriteLine("Ingresa el titulo");
            this.titulo = Console.ReadLine();
            Console.WriteLine("Ingresa el autor");
            this.autor = Console.ReadLine();
            Console.WriteLine("Ingresa el genero");
            this.genero = Console.ReadLine();
            Console.WriteLine("¿Tiene portada?");
            this.portada = checar(Console.ReadLine());
            Console.WriteLine("¿Tiene prologo?");
            this.prologo = checar(Console.ReadLine());
            Console.WriteLine("¿Tiene historia?");
            this.historia = checar(Console.ReadLine());
            Console.WriteLine("¿Tiene epilogo?");
            this.epilogo = checar(Console.ReadLine());
            Console.WriteLine("¿Tiene indice?");
            this.indice = checar(Console.ReadLine());
            Console.WriteLine("¿Tiene imagenes?");
            this.imagenes = checar(Console.ReadLine());
        }

        public override void imprimir()
        {
            Console.WriteLine("\nTitulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Portada: " + convertir(portada));
            Console.WriteLine("Prologo: " + convertir(prologo));
            Console.WriteLine("Historia: " + convertir(historia));
            Console.WriteLine("Epilogo: " + convertir(epilogo));
            Console.WriteLine("Indice: " + convertir(indice));
            Console.WriteLine("Imagenes: " + convertir(imagenes));
        }
    }
}
