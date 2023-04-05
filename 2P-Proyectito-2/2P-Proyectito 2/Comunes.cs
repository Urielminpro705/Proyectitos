using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_2
{
    internal class Comunes:Libros
    {
        public Boolean portada;
        public Boolean contraPortada;
        public Boolean prologo;
        public Boolean historia;
        public Boolean epilogo;
        public Boolean indice;
        public Boolean imagenes;
        public String dimensiones;

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
            Console.WriteLine("¿Tiene contraportada?");
            this.contraPortada = checar(Console.ReadLine());
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
            Console.WriteLine("Ingrese las dimensiones");
            this.dimensiones = Console.ReadLine();

        }
        public override void imprimir()
        {
            Console.WriteLine("\nTitulo: "+titulo);
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
        }

        public virtual Boolean checar(String estado)
        {
            Boolean seleccion=false;
            if (estado == "Si" || estado == "si" || estado=="SI")
            {
                return seleccion = true;
            }
            else
            {
                if (estado == "No" || estado == "no" || estado == "NO")
                {
                    return seleccion = false;
                }
            }
            return seleccion;
        }

        public virtual String convertir(Boolean resultado)
        {
            String estado="NO";
            if (resultado == false)
            {
                estado = "NO";
            }
            else
            {
                if (resultado == true)
                {
                    estado = "SI";
                }
            }
            return estado;
        }
    }
}
