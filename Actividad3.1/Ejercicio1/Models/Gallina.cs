using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Gallina : Ave
    {
        public int Raciones { get; set; }

        static Random azar = new Random();

        public override void Come()
        {
            Raciones += azar.Next(0, 10); // 0 a 9
            acciones.Add($"La Gallina turuleca ha comido: {Raciones} raciones");
        }

        public override int PoneHuevos()
        {
            int huevos = 0;
            if(TieneHambre() == false) // si no tiene hambre pone huevos
            {
                int maximos = Raciones;
                if (maximos > 1)
                {
                    maximos = 2; // ajustamos tope a 2
                }
                huevos = azar.Next(0,maximos); //puede poner 0 o 1
            }
            return huevos;
        }

        public override bool TieneHambre()
        {
            bool tieneHambre = true;
            if (Raciones == 0)
            {
                return true; //tiene hambre porque no hay raciones

            }
            return false;
        }

        public override List<string> CorreRutina()
        {
            Come();
            int huevos = PoneHuevos();
            acciones.Add($"La Gallina turuleca puso huevos: {huevos}");
            return acciones;
        }
    }
}
