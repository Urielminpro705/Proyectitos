using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_2
{
    internal class Premium:Fisico
    {
        public Boolean pastaDura=true;

        public override void imprimir()
        {
            Console.WriteLine("\nTitulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Portada: " + convertir(portada));
            Console.WriteLine("ContraPortada: " + convertir(contraPortada));
            Console.WriteLine("Prologo: " + convertir(prologo));
            Console.WriteLine("Historia: " + convertir(historia));
            Console.WriteLine("Epilogo: " + convertir(epilogo));
            Console.WriteLine("Indice: " + convertir(indice));
            Console.WriteLine("Imagenes: " + convertir(imagenes));
            Console.WriteLine("Dimensiones: " + dimensiones);
            Console.WriteLine("Pasta dura: " + convertir(pastaDura));
        }

    }
}
