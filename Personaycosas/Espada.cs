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
        public int EspadaAtaque { get; set; } = 25;
        public override void Equipar(Personaje character)
        {
            if (character.Espada == null)
            {
                character.Espada = EspadaAtaque;
                Equipado = true;
                character.Fuerza += EspadaAtaque;
            }
            else
            {

            }
        }
        public override void Desequipar(Personaje character)
        { 
        
        }
        public override string ToString()
        {
            return "Espada";
        }
    }
}
