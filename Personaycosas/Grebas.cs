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
        public int GrebasDefensa { get; set; } = 30;


        public override void Equipar(Personaje character)
        {
            character.Grebas = GrebasDefensa;
            Equipado = true;
            character.Defensa += GrebasDefensa;


        }

        public override void Desequipar(Personaje character)
        {
            if (Equipado == true)
            {
                character.Defensa -= GrebasDefensa;
                Equipado = false;
            }
        }

        public override string ToString()
        {
            return "Grebas";
        }
    }
}
