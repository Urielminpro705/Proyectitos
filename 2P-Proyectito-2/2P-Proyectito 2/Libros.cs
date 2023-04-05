using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_2
{
    abstract class Libros
    {
        public String titulo;
        public String autor;
        public String genero;

        public Libros() { }

        public abstract void Leer();
        
        public abstract void imprimir();
        
       
    }
}
