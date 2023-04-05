using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_9
{
    partial class Celular
    {
        private String Gpu;
        Boolean dosSims;
        private int Capacidad;
        private String Compañia;

        public Celular() 
        { 
            
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


        public void setGpu(String gpu)
        {
            this.Gpu = gpu;
            
        }

        public void setSim(Boolean dosSims)
        {
            this.dosSims = dosSims;
            
        }

        public void setCapacidad(int capacidad)
        {
            this.Capacidad = capacidad;
        }

        public void setCompañia(String compañia)
        {
            this.Compañia = compañia;
        }
    }
}
