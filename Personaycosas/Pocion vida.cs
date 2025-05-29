using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public class Pocion_vida:Pocion
    {
        public override int usar(Personaje character)
        {
            
            int VidaPersonaje = character.VidaMaxima;
            Random CuracionAleateoria = new Random();
            int generadordevida = CuracionAleateoria.Next(Minimo, Maximo);
            if (generadordevida>character.VidaMaxima)
            {
                character.Vida = VidaPersonaje;
            }
            else 
            { 
                character.Vida += generadordevida;
                if (character.Vida > character.VidaMaxima)
                {
                    character.Vida = VidaPersonaje;
                }
            }
            return character.Vida;

        }
        public override string ToString()
        {
            return "Pocion de vida";
        }
    }
}
