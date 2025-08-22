using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Zorro:Animal
    {
        Granja granja;
        Random azar = new Random();
        public Zorro(Granja granja) //El zorro debe conocer la granja
        {
            this.granja = granja;
        }

        public bool TieneHambre() { 
            return azar.Next(0,2) == 1;
        }

        public void Come(Ave presa)
        {
            if (presa != null)
            {
                if (TieneHambre())
                {
                    presa.EstaVivo = false;
                    acciones.Add($"Mató a un ave de tipo:" + presa.ToString());
                }
            }
            else
            {
                acciones.Add("No encontró presa.");
            }
            
        }

        public Ave ElegirUnAve()
        {
            Ave elegida = null;

            if (granja != null)
            {
                List<Ave> presas = granja.VerAvesVivas();

                if (presas != null && presas.Count > 0)
                {
                    int idx = azar.Next(0, presas.Count);
                    elegida = presas[idx];
                }

                if (elegida != null)
                    acciones.Add("El zorro ha elegido una presa.");
                else
                    acciones.Add("El zorro no ha encontrado presas.");
            }
            return elegida;
        }

        public override List<string> CorreRutina()
        {
            Ave presa = ElegirUnAve();
            Come(presa);
            return acciones;
        }
    }
}
