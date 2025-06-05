using Personaycosas;
using System.Drawing;
using ZothrasYTobias;
using static System.Runtime.InteropServices.JavaScript.JSType;




Pocion pocionVida()
{
    Pocion Vida = new Pocion_vida();
    
   
    
        Console.WriteLine("Ingrese el valor maximo vida");
        Vida.Maximo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor minimo vida");
        Vida.Minimo = int.Parse(Console.ReadLine());
    
    

    return Vida;
}

Pocion PocionMana()
{
    Pocion Mana = new Pocion_Mana();

    
        Console.WriteLine("Ingrese el valor maximo mana");
        Mana.Maximo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor minimo mana");
        Mana.Minimo = int.Parse(Console.ReadLine());
    
       

    return Mana;

}



    void carga(Personaje p)
{ Casco casco = new Casco();
    Pechera pechera = new Pechera();
    Grebas grebas = new Grebas();
    Espada espada = new Espada();

    Console.WriteLine("Ingrese el color de su personaje");
    p.Color = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de vida que tiene su personaje");
    p.Vida = int.Parse(Console.ReadLine());
    p.VidaMaxima = p.Vida;
    Console.WriteLine("Ingrese la cantidad de defensa que tiene su personaje");
    p.Defensa = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de fuerza que tiene su personaje");
    p.Fuerza = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de mana que tiene su personaje");
    p.Mana = int.Parse(Console.ReadLine());
    p.ManaMaxima = p.Mana;
    p.inventario = new Inventario();
    p.inventario.AgregarItem(casco);
    p.inventario.AgregarItem(pechera);
    p.inventario.AgregarItem(grebas);
    p.inventario.AgregarItem(espada);
    p.inventario.AgregarItem(pocionVida());
    p.inventario.AgregarItem (PocionMana());

}

void mostramela(Personaje p)
{
    Console.WriteLine("Color: " + p.Color);
    Console.WriteLine("Vida: " + p.Vida);
    Console.WriteLine("Defensa: " + p.Defensa);
    Console.WriteLine("Fuerza: " + p.Fuerza);
    Console.WriteLine("Mana: " + p.Mana);
    Console.WriteLine("Inventario:");
    foreach (var item in p.inventario.Items)
    {
        Console.WriteLine($"- {item}");
    }


}
void CambioDeColor(Personaje p)
{
    string colornuevo;
    Console.WriteLine("El color actual de su personaje (Personaje 1) es: " + p.Color);
    Console.WriteLine("Porfavor indique cual es el nuevo color de su personaje");
    colornuevo = Console.ReadLine();
    p.Color = colornuevo;
    Console.WriteLine("Su nuevo color es: " + p.Color);
}

void RecibirDaño(Personaje p)
{
    int dañoquemehicieron;
    Console.WriteLine("Aurelion sol bajo desde las estrellas y te escupio con fuego intelestelar, ¿Cuanto daño te ha hecho?");
    dañoquemehicieron = int.Parse(Console.ReadLine());
    p.Vida -= dañoquemehicieron;
    Console.WriteLine("La nueva vida de su personaje es: ");
    Console.WriteLine(" " + p.Vida);
}Personaje p1 = new Personaje();




Console.WriteLine("Cree su primer personaje");
carga(p1);
Personaje p2 = new Personaje();
Console.WriteLine("Cree su segundo personaje");
carga(p2);
Console.Clear();
Console.WriteLine("Datos del personaje uno: ");
mostramela(p1);
Console.WriteLine("-----------");
Console.WriteLine("Datos del personaje dos: ");
mostramela(p2);


Console.WriteLine("Escriba la accion que quiera hacer a continuacion teniendo en cuenta las distintas opciones, sus opciones son: ");
Console.WriteLine("1: Cambiar Color ");
Console.WriteLine("2: Recibir Daño ");
Console.WriteLine("3: Atacar ");
Console.WriteLine("4: Curar ");
string accion = Console.ReadLine();

do
{
    Console.Clear();
    Console.WriteLine("Personaje 1");
    mostramela(p1);
    Console.WriteLine("Personaje 2");
    mostramela(p2);
    Console.WriteLine("ingrese una opcion");
    Console.WriteLine("1: Cambiar color");
    Console.WriteLine("2: Recibir daño");
    Console.WriteLine("3: Atacar");
    Console.WriteLine("4: Inventario");
    string swit = Console.ReadLine();
    switch (swit)
    {

        case "Cambiar color":
            Console.WriteLine("elija otro color");
            p1.CambiarColor(Console.ReadLine());
            break;
        case "Recibir daño":
            Console.WriteLine("ingrese el daño recibido");
            p1.RecibirDaño(int.Parse(Console.ReadLine()));
            break;
        case "Atacar":
            p1.Atacar(p2);
            break;

        case "Inventario":
            Console.WriteLine("Que personaje quieres usar");
            Console.WriteLine("1: Personaje uno");
            Console.WriteLine("2: Personaje dos");
            string opcion = Console.ReadLine();
            Console.Clear();
            switch (opcion)
            {
                case "Personaje uno":

                    int i = 0;
                    foreach (var item in p1.inventario.Items)
                    {
                        Console.WriteLine($"{i++} {item}");
                    }
                    int seleccionado = int.Parse(Console.ReadLine());
                    Item itemSeleccionado = p1.inventario.Items[seleccionado];
                    if (itemSeleccionado is IUsable usable)
                    {
                        usable.usar(p1);
                    }
                    Console.ReadKey();

                    break;


            }
          break;
        case "Personaje dos":
            Console.WriteLine("A donde quieres acceder, armadura o pociones?");
            Console.WriteLine("1: Armadura");
            Console.WriteLine("2: Objetos");
            string opcion3 = Console.ReadLine();
            switch (opcion3)
            {
                case "Armadura":

                    break;

                case "Objetos":





                    {
                        Console.WriteLine("Tienes dos pociones, una de vida y otra de mana, ¿Cual quieres usar?");
                        Console.WriteLine("1: Pocion de vida");
                        Console.WriteLine("2: Pocion de mana");
                        int Opcion = int.Parse(Console.ReadLine());
                        if (Opcion == 1)
                        {
                            Item pocionVida2 = null;
                            foreach (var item in p2.inventario.Items )
                            {
                                if (item is Pocion_vida)
                                {
                                    pocionVida2 = item;
                                    break;
                                }
                            }
                            if (pocionVida2 != null)
                            {
                                int curado = ((Pocion_vida)pocionVida2).usar(p2);
                                Console.WriteLine($"¡Se curó {curado} puntos de vida!");
                                p1.inventario.QuitarItem(pocionVida2);
                            }
                            else
                            {
                                Console.WriteLine("No tienes poción de vida.");
                            }
                        }
                        if (Opcion == 2)
                        {
                            Item pocionMana2 = null;
                            foreach (var item in p2.inventario.Items )
                            {
                                if (item is Pocion_Mana)
                                {
                                    pocionMana2 = item;
                                    break;
                                }
                            }
                            if (pocionMana2 != null)
                            {
                                int curado = ((Pocion_vida)pocionMana2).usar(p2);
                                Console.WriteLine($"¡Se curó {curado} puntos de vida!");
                                p1.inventario.QuitarItem (pocionMana2);
                            }
                            else
                            {
                                Console.WriteLine("No tienes poción de mana.");
                            }
                        }
                    }
                    break;
            }
            break;



    }
    if (p2.Vida == 0)
    {
        Console.WriteLine("Ganaste");
    }
} while (p2.Vida != 0);

Console.ReadKey();
