using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public interface IEquipable
    {
        void Equipar(Personaje character);
         
        void Desequipar(Personaje character);
    }
}
