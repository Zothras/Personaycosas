using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZothrasYTobias;

namespace Personaycosas
{
    public class Inventario
    {
        public Personaje Personaje { get; set; }
        public List<Item> Items { get; set; } = new();

        public void AgregarItem(Item item)
        {
            if (item.inventar == null)
            {
                item.inventar = this;
            }
            Items.Add(item);
        }
        public void QuitarItem(Item item)
        {
            if (item.inventar == null)
            {
                item.inventar = this;
            }
            Items.Remove(item);
        }
    }
}
