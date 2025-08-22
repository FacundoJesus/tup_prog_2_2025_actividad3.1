using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Venteveo:Ave
    {
        static Random azar = new Random();

        public override void Come()
        {
            if (TieneHambre())
            {
                acciones.Add("El benteveo ha comido.");
            }
            else
            {
                acciones.Add("El benteveo no tiene hambre.");
            }
        }

        public override bool TieneHambre()
        {
            return azar.Next(0, 2) == 1; //Si es 1 == 1 : True
        }

        public override int PoneHuevos()
        {
            int huevos = 0;
            if (TieneHambre() == false)
            {
                huevos = azar.Next(0, 2);
            }
            return huevos;
        }

        public override List<string> CorreRutina()
        {
            Come();
            int huevos = PoneHuevos();
            acciones.Add($"El benteveo ha puesto {huevos} huevos.");
            return acciones;
        }
    }
}
