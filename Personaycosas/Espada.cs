using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    internal class Espada:Equipo
    {
        public int EspadaAtque { get; set; } = 15;


        public override void Equipar(Personaje character)
        {
            character.Espada = EspadaAtque;
            Equipado = true;
            character.Fuerza += EspadaAtque;


        }

        public override void Desequipar(Personaje character)
        {
            if (Equipado == true)
            {
                character.Fuerza -= EspadaAtque;
                Equipado = false;
            }
        }

        public override string ToString()
        {
            return "Espada";
        }
    }
}
