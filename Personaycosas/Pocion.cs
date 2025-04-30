using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public abstract class Pocion:Personaje
    {
        public int Minimo { get; set; }
        public int Maximo { get; set; }

        public abstract int usar(Personaje character);
    }
}
