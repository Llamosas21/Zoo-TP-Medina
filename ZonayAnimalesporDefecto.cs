using System;
using System.Collections.Generic;

namespace Zoologico
{
    public static class ZonasAnimalesDefecto
    {
        public static List<Zona> zonas = new List<Zona>();

        static ZonasAnimalesDefecto()
        {
            // Inicialización de zonas
            Zona zonaSavanna = new Zona("Savanna");
            Zona zonaSelva = new Zona("Selva");

            // Inicialización de animales con configuraciones por defecto
            Leon leon1 = new Leon(1, 5, "Simba", "Masculino");
            Elefante elefante1 = new Elefante(2, 10, "Dumbo", "Femenino");
            Tigre tigre1 = new Tigre(3, 7, "Shere Khan", "Femenino");

            // Agregar animales a las zonas
            zonaSavanna.AgregarAnimal(leon1);
            zonaSelva.AgregarAnimal(elefante1);
            zonaSelva.AgregarAnimal(tigre1);

            // Agregar las zonas a la lista
            zonas.Add(zonaSavanna);
            zonas.Add(zonaSelva);
        }

        // Método para mostrar la información de todas las zonas y sus animales
        public static void MostrarZonasYAnimales()
        {
            Console.Clear();
            foreach (var zona in zonas)
            {
                zona.MostrarInformacionAnimal();  
            }
        }
    }
}
