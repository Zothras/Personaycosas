using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public class Pocion_Mana:Pocion
    {
           public override int usar(Personaje character)
        {
            Console.WriteLine("Ingrese la curacion minima de la pocion de mana");
            Minimo = int.Parse(Console.ReadLine());
            if (Minimo < 1)
            {

                Minimo= 1;
            }
            Console.WriteLine("Ingrese la curacion maxima de la pocion de mana");
            Maximo = int.Parse(Console.ReadLine());
            if (Maximo > Vida)
            {
               Maximo = Vida;
            }

            Random managen = new Random();
            int curacionmana = managen.Next(Minimo-Maximo); 
            return curacionmana;        
        }
    }
}
