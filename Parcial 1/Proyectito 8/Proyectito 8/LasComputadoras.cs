using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito_8
{
    partial class LasComputadoras
    {

        private String Marca;
        private String Procesador;
        private String Color;
        private int MemoriaRam;
        private int DDCapacidad;
        private Boolean DiscoDuroSSD;
        private Boolean GraficosExtInt;
        public LasComputadoras()
        {
            Marca = "Patito";
            Procesador = "Intel";
            MemoriaRam = 8;
            DDCapacidad = 512;
        }

        public LasComputadoras(string Marca, string Procesador, int memoriaRam, int DDCapacidad)
        {
            this.Marca = Marca;
            this.Procesador = Procesador;
            this.MemoriaRam = memoriaRam;
            this.DDCapacidad = DDCapacidad;
        }

        public void setOpcionales(string color, bool DDSSD, bool graficos)
        {
            Color = color;
            DiscoDuroSSD = DDSSD;
            GraficosExtInt = graficos;
        }

        public String GetOpcionales()
        {
            return "Con un color " + Color +
                "\nDisco de estado solido: " + DiscoDuroSSD +
                "\nTarjeta grafica externa: " + GraficosExtInt;
        }

        public String getCaracIniciales()
        {
            return "Marca: " + Marca +
                "\nProcesador: " + Procesador +
                "\nMemoria Ram: " + MemoriaRam +
                "\nCapacidad del disco duro: " + DDCapacidad;
        }
    }
}
