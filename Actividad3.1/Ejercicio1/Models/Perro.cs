using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Perro : Animal
    {
        public override List<string> CorreRutina()
        {
            string v = Ladrar();
            acciones.Add($@"El perro ladra: {v}");
            return acciones;
        }

        public string Ladrar()
        {
            return "Guau guau";
        }
    }
}
