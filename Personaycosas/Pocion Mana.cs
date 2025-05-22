using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public class Pocion_Mana:Pocion
    {
           public override int usar(Personaje character)
        {
            int ManaPersonaje = character.ManaMaxima;
            Random RecuperacionDeManaAletoria = new Random();
            int generadordemana = RecuperacionDeManaAletoria.Next(Minimo, Maximo);
            if (generadordemana > character.ManaMaxima)
            {
                character.Mana = ManaPersonaje;
            }
            else
            {
                character.Mana += generadordemana;
                if (character.Mana > character.ManaMaxima)
                {
                    character.Mana= ManaPersonaje;
                }
            }
            return character.Mana;
        }
    }
}
