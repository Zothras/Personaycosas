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
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Mana { get; set; }


        public void Carga()
        {
            Console.WriteLine("Ingrese el color de su personaje");
            Color = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de vida que tiene su personaje");
            Vida = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de defensa que tiene su personaje");
            Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de fuerza que tiene su personaje");
            Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mana que tiene su personaje");
            Mana = int.Parse(Console.ReadLine());
        }

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