using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Granja
    {
        private List<Animal> animales = new List<Animal>(); //Lista de animales

        public Granja() {
            animales.Add(new Perro());
            animales.Add(new Gallina());
            animales.Add(new Zorro(this));
            animales.Add(new Venteveo());
        }
        public List<Ave> VerAvesVivas()
        {
            List<Ave> aves = new List<Ave>();

            foreach (Animal animal in animales) {
                if(animal is Ave)
                {
                    Ave aux = animal as Ave;
                    if (aux.EstaVivo)
                    {
                        aves.Add(aux);
                    }
                }
            }
            return aves;
        }
        public List<string> CorrerRutina()
        {
            List<string> acciones = new List<string>();

            foreach (Animal animal in animales) {
                List<string> accionesAnimal = animal.CorreRutina();
                acciones.AddRange(accionesAnimal.ToArray());
            }
            return acciones;
        }

    }
}
