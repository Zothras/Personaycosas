using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    internal class Grebas: Equipo
    {
        public int GrebasDefensa { get; set; } = 15;


        public override void Equipar(Personaje character)
        {

            if (character.Grebas == null)
            {
                character.Pechera = GrebasDefensa;
                Equipado = true;
                character.Defensa += GrebasDefensa;


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
            return "Grebas";
        }
    }
}
