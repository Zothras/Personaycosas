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
            Console.WriteLine("Ingrese la curacion minima de la pocion de mana");
            Minimo = int.Parse(Console.ReadLine());
            if (Minimo < 1)
            {

                Minimo = 1;
            }
            Console.WriteLine("Ingrese la curacion maxima de la pocion de mana");
            Maximo = int.Parse(Console.ReadLine());
            if (Maximo > Vida)
            {
                Maximo = Vida;
            }

            Random vidagen = new Random();
            int curacionvida = vidagen.Next(Minimo - Maximo);
            return curacionvida;
        }
    }
}
