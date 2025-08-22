using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Ave:Animal
    {
        public bool EstaVivo { get; set; } = false;

        public abstract void Come();
        public abstract int PoneHuevos();

        public abstract bool TieneHambre();
    }
}
