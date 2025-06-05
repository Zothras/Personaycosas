using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public abstract class Equipo : Item, IEquipable
    {
        public bool Equipado { get; set; }

        public abstract void Desequipar(Personaje character);
        public abstract void Equipar(Personaje character);
    }
}
