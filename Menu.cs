using System;
using System.Threading;
using Zoologico;

namespace Zoologico
{
    public static class Menu
    {
        public static void consolaInteractiva()
        {
            int opcion;
            while (true) 
            {
                Menuprincipal();
                opcion = int.Parse(Console.ReadLine());
                
                if (opcion == 1)
                {
                    cerrarPrograma();
                    break; 
                }
                else if (opcion == 2)
                {
                    ZonasAnimalesDefecto.MostrarZonasYAnimales();
                    MenuZonas();
                    int opcionZona = int.Parse(Console.ReadLine());

                    if (opcionZona == 1)
                    {
                        continue; 
                    }
                    else if (opcionZona == 2)
                    {
                        AgregarZona();
                    }
                    else if (opcionZona == 3)
                    {
                        EliminarZona();
                    }
                }
                else if (opcion == 3)
                {
                    // Lógica para mostrar animales
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }
            }
        }

        public static void cerrarPrograma()
        {
            Console.Clear();
            Console.WriteLine("Cerrando programa...");
            Thread.Sleep(3000);
            Console.Clear();
        }

        public static void Menuprincipal()
        {
            Console.Clear();
            Console.WriteLine("  ______      _______   _______  \n" +
                              " /__   /     / ___  /  / ___  /  \n" +
                              "   /  /     / /  / /  / /  / /   \n" +
                              "  /  /___  / /__/ /  / /__/ /    \n" +
                              " /______/  \\_____/   \\_____/   \n");
            // Opciones del menú
            Console.WriteLine("1. Salir");
            Console.WriteLine("2. Mostrar Zonas");
            Console.WriteLine("3. Mostrar Animales");
            Console.Write("\nIngrese una opción: ");
        }

        public static void MenuZonas()
        {
            Console.WriteLine("\nMenú de Zonas:");
            Console.WriteLine("1. Salir");
            Console.WriteLine("2. Crear Zonas");
            Console.WriteLine("3.Eliminar Zonas");
            Console.Write("\nIngrese una opción: ");
        }
       public static void AgregarZona()
        {
            string nombreZona;
            
            while (true)
            {
                Console.Write("\nIngrese el nombre de la nueva zona: ");
                nombreZona = Console.ReadLine().Trim(); // Elimina espacios en blanco al inicio y al final

                // Verifica si el nombre es nulo, vacío o solo contiene números
                if (string.IsNullOrEmpty(nombreZona) || EsNumero(nombreZona))
                {
                    Console.WriteLine("Error: El nombre de la zona no puede estar vacío ni ser un número. Intente de nuevo.");
                }
                else if (ZonaExistente(nombreZona))
                {
                    Console.WriteLine($"La zona '{nombreZona}' ya existe. Intente con un nombre diferente.");
                    continue; // Vuelve al inicio del bucle para pedir un nuevo nombre
                }
                else
                {
                    Zona nuevaZona = new Zona(nombreZona);
                    ZonasAnimalesDefecto.zonas.Add(nuevaZona);
                    Console.WriteLine($"Zona '{nombreZona}' agregada exitosamente.");
                    break; // Sale del bucle al agregar la nueva zona
                }
            }
        }
        private static bool EsNumero(string valor)
        {
            return int.TryParse(valor, out _); 
        }
        private static bool ZonaExistente(string nombreZona)
        {
            foreach (var zona in ZonasAnimalesDefecto.zonas)
            {
                if(zona.ObtenerNombreZona().Equals(nombreZona, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        public static void EliminarZona()
        {
            if (ZonasAnimalesDefecto.zonas.Count == 0)
            {
                Console.WriteLine("No hay zonas disponibles para eliminar.");
                return;
            }

            Console.WriteLine("\nZonas disponibles para eliminar:");
            ZonasAnimalesDefecto.MostrarZonasYAnimales(); // Muestra las zonas actuales

            Console.Write("\nIngrese el nombre de la zona que desea eliminar: ");
            string nombreZona = Console.ReadLine().Trim();

            // Busca la zona por nombre
            Zona zonaAEliminar = null;
            foreach (var zona in ZonasAnimalesDefecto.zonas)
            {
                if (zona.ObtenerNombreZona().Equals(nombreZona, StringComparison.OrdinalIgnoreCase))
                {
                    zonaAEliminar = zona; // Se guarda la zona a eliminar
                    break;
                }
            }

            // Si se encontró la zona, se elimina
            if (zonaAEliminar != null)
            {
                ZonasAnimalesDefecto.zonas.Remove(zonaAEliminar);
                Console.WriteLine($"Zona '{nombreZona}' eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine($"No se encontró la zona '{nombreZona}'.");
            }
        }
    }
}