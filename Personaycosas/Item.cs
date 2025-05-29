using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public abstract class Item
    {
        public Inventario? inventar { get; set; }
        public abstract int usar(Personaje character);
    }
}
