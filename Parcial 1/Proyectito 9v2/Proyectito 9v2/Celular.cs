using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_9v2
{
    partial class Celular
    {
        private String Gpu;
        Boolean dosSims;
        private int Capacidad;
        private String Compañia;

        public Celular()
        {
            this.Gpu = "Procesador  mediocre";
            this.dosSims = false;
            this.Capacidad = 32;
            this.Compañia = "Telcel";
        }

        

        public Celular(String gpu, Boolean dosSims, int capacidad, String compañia)
        {
            this.Gpu = gpu;
            this.dosSims = dosSims;
            this.Capacidad = capacidad;
            this.Compañia = compañia;
        }

        public String getTelefono()
        {
            return "GPU: " + Gpu +
                "\nTiene dos sims: " + dosSims +
                "\nCapacidad en GB: " + Capacidad +
                "\nCompañia: " + Compañia;
        }

        public void setIntermedio(String gpu, Boolean dosSims, int capacidad, String compañia)
        {
            this.Gpu = gpu;
            this.dosSims = dosSims;
            this.Capacidad = capacidad;
            this.Compañia = compañia;
        }

        public void setOpcional(String gpu, Boolean dosSims, int capacidad, String compañia)
        {
            this.Gpu = gpu;
            this.dosSims = dosSims;
            this.Capacidad = capacidad;
            this.Compañia = compañia;
        }
       
    }
}
