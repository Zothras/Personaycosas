using Personaycosas;
using ZothrasYTobias;

//Hola. Este es mi codigo, hoy estamos a 7/6/2025, me pondre a hacer cambios que me parecen interesantes para mejor mi logica como programador, es... algo de pasion total todo esto

Personaje p1 = new Personaje();
Personaje p2 = new Personaje();

void MostrarEstadoGeneral()
{
    Console.WriteLine("Personaje 1");
    mostramela(p1);
    Console.WriteLine("-----------");
    Console.WriteLine("Personaje 2");
    mostramela(p2);
    Console.WriteLine();
}

void UsoDeObjetos(Personaje p)
{
    int indiceItem = 0;
    foreach (var item in p.inventario.Items)
    {
        Console.WriteLine($"{indiceItem++} {item}");
    }
    int itemSeleccionadoIndice = int.Parse(Console.ReadLine());
    Item itemSeleccionado = p1.inventario.Items[itemSeleccionadoIndice];
    if (itemSeleccionado is IUsable usable)
    {
        int restaurado = usable.usar(p);
        Console.WriteLine($"¡Se restauraron {restaurado} puntos!");
        Console.WriteLine("Tu pocion quedo vacia pero tal vez es posible encontrar otra o llenarla... decides tirar el frasco vacio de todas maneras.");
        p.inventario.QuitarItem(itemSeleccionado);
    }

    if (itemSeleccionado is IEquipable equipable && itemSeleccionado is Equipo equipo)
    {
        Console.WriteLine("Deseas Equipar o Desequipar un objeto?");
        string OpcionEquipable = Console.ReadLine();
        if (OpcionEquipable == "Equipar")
        {
            if (equipo.Equipado == false)
            {
                equipable.Equipar(p);
                Console.WriteLine("Te sientes un poco mas fuerte...");
            }
            else
            {
               Console.WriteLine("Ya tienes esta pieza de armadura equipada. Intenta con otra.");

            }

        }
        else
        {
            if (equipo.Equipado == true)
            {
                equipable.Desequipar(p);
                Console.WriteLine("Te sientes mas ligero, pero ciertamente mas desprotegido...");
            }
            else
            {
                Console.WriteLine("Ya tienes esta pieza de armadura equipada. Intenta con una la cual te hayas equipado anteriormente.");
            }

        }

    }
}
Pocion CrearPocion(string Tipo)
{
    Pocion Vida = new Pocion_vida();

    Pocion pocion;
    if (Tipo == "vida")
    {
        pocion = new Pocion_vida();
        Console.WriteLine("Ingrese el valor minimo vida");
    }
    else
    {
        pocion = new Pocion_Mana();
        Console.WriteLine("Ingrese el valor minimo mana");
    }

    pocion.Minimo = int.Parse(Console.ReadLine());
    if (Tipo == "vida")
        Console.WriteLine("Ingrese el valor maximo vida");
    else
        Console.WriteLine("Ingrese el valor maximo mana");
    pocion.Maximo = int.Parse(Console.ReadLine());

    return pocion;
}

void carga(Personaje p)
{
    Casco casco = new Casco();
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
    p.inventario.AgregarItem(CrearPocion("vida"));
    p.inventario.AgregarItem(CrearPocion("mana"));
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
}

//CARGA DE PERSONAJE--------------------------------------------------------------------------------------------



Console.WriteLine("Cree su primer personaje");
carga(p1);
Console.Clear();
Console.WriteLine("Cree su segundo personaje");
carga(p2);
Console.Clear();
do
{
    MostrarEstadoGeneral();
    Console.WriteLine("Presiona cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Escriba la acción que quiera hacer a continuación teniendo en cuenta las distintas opciones, sus opciones son:");
    Console.WriteLine("1: Cambiar color");
    Console.WriteLine("2: Recibir daño");
    Console.WriteLine("3: Atacar");
    Console.WriteLine("4: Inventario");
    string menuPrincipalOpcion = Console.ReadLine();

    switch (menuPrincipalOpcion)
    {
        case "Cambiar color":
            Console.Clear();
            Console.WriteLine("Elija otro color");
            p1.CambiarColor(Console.ReadLine());
            Console.WriteLine("Color cambiado.");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;

        case "Recibir daño":
            Console.Clear();
            Console.WriteLine("Ingrese el daño recibido");
            p1.RecibirDaño(int.Parse(Console.ReadLine()));
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;

        case "Atacar":
            Console.Clear();
            int daño = p1.Atacar(p2);
            if (daño > 0)
                Console.WriteLine($"¡Atacaste e hiciste {daño} de daño!");
            else
                Console.WriteLine("El ataque no fue suficiente para superar la defensa.");
            MostrarEstadoGeneral();
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;

        case "Inventario":
            Console.Clear();
            MostrarEstadoGeneral();
            Console.WriteLine("¿Qué personaje quieres usar?");
            Console.WriteLine("1: Personaje uno");
            Console.WriteLine("2: Personaje dos");
            string menuInventarioPersonaje = Console.ReadLine();
            Console.Clear();

            switch (menuInventarioPersonaje)
            {
                case "Personaje uno":
                    UsoDeObjetos(p1);
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            break;

        case "Personaje dos":
            UsoDeObjetos(p2);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            break;
    }

    if (p2.Vida == 0)
    {
        Console.WriteLine("Has vencido a tu enemigo. Tampoco era muy fuerte que digamos,... felicidades.");
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }

} while (p2.Vida !>= 0);

Console.ReadKey();