using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Animal
    {
        protected List<string> acciones = new List<string>();

        public abstract List<string> CorreRutina();
    }
}
