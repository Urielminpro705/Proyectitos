using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Act_Objetos
{
    internal class Bicicleta:Vehiculos
    {
        public Bicicleta() { }

        public void asignar()
        {
            setCapacidad("Maximo 2 personas");
            setLlantas("Tiene 2 llantas");
            setPuertas("No tiene puertas");
            setVentanas("No tiene ventanas");
        }
    }
}
