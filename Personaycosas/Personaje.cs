using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZothrasYTobias
{
    public class Personaje
    {
        public string Color { get; set; }
        public int Vida { get; set; }
        public int VidaMaxima { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Mana { get; set; }
        public int ManaMaxima { get; set; }



        public void CambiarColor(string nuevo)
        {

            Color = nuevo;
        }

        public int RecibirDaño(int FuerAtac)
        {
            int daño = FuerAtac - Defensa;
            if (daño < 0)
            {
                daño = 0;
            }
            Vida -= daño;

            return daño;
        }
        public int Atacar(Personaje o)
        {
            if (Mana > 0)
            {
                Mana--;
                return o.RecibirDaño(Fuerza);
            }
            else
            {
                return 0;
            }

        }
    }
}