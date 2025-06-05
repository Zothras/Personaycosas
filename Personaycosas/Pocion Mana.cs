using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public class Pocion_Mana : Pocion, IUsable
    {
        public override int usar(Personaje character)
        {
            Random regeneracionaleatoria = new Random();
            int generadordemana = regeneracionaleatoria.Next(Minimo, Maximo);
            int manaantes = character.Vida;
            character.Vida += generadordemana;
            if (character.Vida > character.ManaMaxima)
                character.Vida = character.ManaMaxima;
            return character.Vida - manaantes;
        }
        public override string ToString()
        {
            return "Pocion de mana";
        }
    }
}
