using System;
using System.Collections.Generic; 

namespace Zoologico
{
    public abstract class Animal
    {
        abstract public void EmitirSonido();
        abstract public string MostrarMarca();
        abstract public string Mostraredad();
        abstract public string Mostrarnombre();
        abstract public string Mostrargenero();
    }

    class Leon : Animal
    {
        // Propiedades
        private int marca;
        private int edad;
        private string nombre;
        private string genero;

        //Constructor
        public Leon(int marca, int edad, string nombre, string genero)
        {
          this.marca = marca;
          this.edad = edad;
          this.nombre = nombre;
          this.genero = genero;
        }

        // Métodos
        public override void EmitirSonido()
        {
            Console.WriteLine("RAWR");
        }

        public override string MostrarMarca()
        {
            return this.marca.ToString();
        }
        public override string Mostraredad()
        {
            return this.edad.ToString();
        }
        public override string Mostrarnombre()
        {
            return this.nombre;
        }
        public override string Mostrargenero()
        {
            return this.genero.ToString();
        }
    }
    class Elefante : Animal
    {
        // Propiedades
        private int marca;
        private int edad;
        private string nombre;
        private string genero;
  
        //Constructor
        public Elefante(int marca, int edad, string nombre, string genero)
        {
          this.marca = marca;
          this.edad = edad;
          this.nombre = nombre;
          this.genero = genero;
        }
  
        // Métodos
        public override void EmitirSonido()
        {
            Console.WriteLine("Bruuuuu");
        }
        public override string MostrarMarca()
        {
            return this.marca.ToString();
        }
        public override string Mostraredad()
        {
            return this.edad.ToString();
        }
        public override string Mostrarnombre()
        {
            return this.nombre;
        }
        public override string Mostrargenero()
        {
            return this.genero.ToString();
        }
    }
    class Tigre : Animal
    {
        // Propiedades
        private int marca;
        private int edad;
        private string nombre;
        private string genero;
  
        //Constructor
        public Tigre(int marca, int edad, string nombre, string genero)
        {
          this.marca = marca;
          this.edad = edad;
          this.nombre = nombre;
          this.genero = genero;
        }
  
        // Métodos
        public override void EmitirSonido()
        {
            Console.WriteLine("RARR");
        }
        public override string MostrarMarca()
        {
            return this.marca.ToString();
        }
        public override string Mostraredad()
        {
            return this.edad.ToString();
        }
        public override string Mostrarnombre()
        {
            return this.nombre;
        }
        public override string Mostrargenero()
        {
            return this.genero.ToString();
        }
    }


//<---------------------- CLASE ZONA ---------------------- >
    
    public class Zona
    {
        // Propiedades
        private String nombreZona;
        private List<Animal> animales;

        // Constructor
        public Zona(string nombreZona)
        {
            this.nombreZona = nombreZona;
            animales = new List<Animal>();
        }

        // Métodos
        public void AgregarAnimal(Animal animal)
        {
          animales.Add(animal);    
        }
        public List<Animal> ObtenerLista(){
            return this.animales;
        }
        public string ObtenerNombreZona()
        {
            return this.nombreZona;
        }
        public void MostrarAnimales()
        {
          Console.WriteLine($"Zona: {nombreZona}");
            foreach(Animal animal in animales)
                {
                  Console.WriteLine(animal + " " + animal.Mostrarnombre());
              }
        }
        public void ImprimirNombreZonaEnColor(ConsoleColor color)
        {
        Console.ForegroundColor = color;
        Console.WriteLine($"Zona: {nombreZona}");
        Console.ResetColor();
        }
        public void MostrarInformacionAnimal()
        {
            ImprimirNombreZonaEnColor(ConsoleColor.DarkYellow);
            Console.WriteLine();
            foreach(Animal animal in animales)
                {
                  Console.WriteLine("Nombre: " + animal.Mostrarnombre());
                  Console.WriteLine("Marca: " + animal.MostrarMarca());
                  Console.WriteLine("Edad: " + animal.Mostraredad());
                  Console.WriteLine("Género: " + animal.Mostrargenero());
                  Console.WriteLine();
                }
        }
    }
}