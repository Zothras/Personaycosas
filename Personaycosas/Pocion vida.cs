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
            Random curacionAleatoria = new Random();
            int generadordevida = curacionAleatoria.Next(Minimo, Maximo);
            int vidaAntes = character.Vida;
            character.Vida += generadordevida;
            if (character.Vida > character.VidaMaxima)
                character.Vida = character.VidaMaxima;

            return character.Vida - vidaAntes;

        }

        public override string ToString()
        {
            return "Pocion de vida";
        }
    }
}
