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
        public int CascoDefensa { get; set; } = 10;


        public override void Equipar(Personaje character)
        {
            
            if (character.Casco == null)
            {
                character.Casco = CascoDefensa;
                Equipado = true;
                character.Defensa += CascoDefensa;


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
            return "Casco";
        }
    }
}
