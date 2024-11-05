using System;
using System.Threading;
using Zoologico;

namespace Zoologico
{
    public static class Menu
    {
        public static void consolaInteractiva()
        {
            Console.Clear();
            int opcion;
            Console.WriteLine("  ______      _______   _______  \n" +
                              " /__   /     / ___  /  / ___  /  \n" +
                              "   /  /     / /  / /  / /  / /   \n" +
                              "  /  /___  / /__/ /  / /__/ /    \n" +
                              " /______/  \\_____/   \\_____/   \n");
            // Opciones del menú
            Console.WriteLine("1. Salir");
            Console.WriteLine("2. Mostrar Zonas");
            Console.WriteLine("3. Mostrar Animales");

            // Solicitar al usuario que ingrese una opción
            Console.Write("\nIngrese una opción: ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                cerrarPrograma();
            }
            else if (opcion == 2)
            {
               ZonasAnimalesDefecto.MostrarZonasYAnimales();
            }
            else if (opcion == 3)
            {
                // Lógica para mostrar animales (opcional)
            }
        }

        public static void cerrarPrograma()
        {
            Console.Clear();
            Console.WriteLine("Cerrando programa...");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
