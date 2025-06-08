using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public class Casco : Equipo
    {
        public int CascoDefensa { get; set; } = 15;


        public override void Equipar(Personaje character)
        {
                character.Casco = CascoDefensa;
                Equipado = true;
                character.Defensa += CascoDefensa;
                

        }

        public override void Desequipar(Personaje character)
        {
            if (Equipado == true)
            {
                character.Defensa -= CascoDefensa;
                Equipado = false;
            }
        }

        public override string ToString()
        {
            return "Casco";
        }
    }
}
