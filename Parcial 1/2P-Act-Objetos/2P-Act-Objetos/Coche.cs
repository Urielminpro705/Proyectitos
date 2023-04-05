using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Act_Objetos
{
    
    internal class Coche:Vehiculos
    {
        public Coche() { }

        public void asignar()
        {
            setCapacidad("Un coche promedio tiene espacio para 5 personas");
            setLlantas("Tiene 4 llantas");
            setPuertas("Tiene 4 puertas");
            setVentanas("Tiene 4 ventanas");
        }

        
    }


}
