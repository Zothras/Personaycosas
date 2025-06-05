using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    internal class Pechera:Equipo
    {
        public int PecheraDefensa { get; set; } = 20;


        public override void Equipar(Personaje character)
        {

            if (character.Pechera == null)
            {
                character.Pechera = PecheraDefensa;
                Equipado = true;
                character.Defensa += PecheraDefensa;


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
            return "Pechera";
        }
    }
}
