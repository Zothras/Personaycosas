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
        public int PecheraDefensa { get; set; } = 30;


        public override void Equipar(Personaje character)
        {
            character.Pechera = PecheraDefensa;
            Equipado = true;
            character.Defensa += PecheraDefensa;


        }

        public override void Desequipar(Personaje character)
        {
            if (Equipado == true)
            {
                character.Defensa -= PecheraDefensa;
                Equipado = false;
            }
        }

        public override string ToString()
        {
            return "Pechera";
        }
    }
}
