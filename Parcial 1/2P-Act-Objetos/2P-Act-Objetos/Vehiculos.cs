using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Act_Objetos
{
    internal class Vehiculos
    {
        private String capacidad;
        private String llantas;
        private String puertas;
        private String ventanas;


        public Vehiculos() { }

        public Vehiculos(String capacidad, String llantas, String puertas, String ventanas)
        {
            this.capacidad= capacidad;
            this.llantas= llantas;
            this.puertas= puertas;
            this.ventanas= ventanas;
        }

        public void asignar()
        {
            Console.WriteLine("No hay datos");
        }

        public String getCapacidad() {
            return capacidad;
        }

        public String getLlantas()
        {
            return llantas;
        }

        public String getPuertas()
        {
            return puertas;
        }

        public String getventanas()
        {
            return ventanas;
        }

        public void setCapacidad(String capacidad)
        {
            this.capacidad = capacidad;
        }

        public void setLlantas(String llantas)
        {
            this.llantas = llantas;
        }

        public void setPuertas(String puertas)
        {
            this.puertas = puertas;
        }

        public void setVentanas(String ventanas)
        {
            this.ventanas = ventanas;
        }
    }

}
