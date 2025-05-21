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
            int VidaPersonaje = character.Vida;
            Random CuracionAleateoria = new Random();
            CuracionAleateoria.Next(Minimo - Maximo);
            if (CuracionAleateoria>character.Vida)
            {
                character.Vida = VidaPersonaje;
            }

        }
    }
}
