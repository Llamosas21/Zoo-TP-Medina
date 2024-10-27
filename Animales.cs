namespace Zoologico{
    abstract class Animal
    {
        public virtual void EmitirSonido()
        {
         Console.WriteLine("");
        }
    }
    class Leon : Animal
    {
        //Propiedades
        private int marca;
        private int edad;
        private string nombre;
        private bool genero;

        //Métodos
        public override void EmitirSonido()
        {
            Console.WriteLine("RAWR");
            base.EmitirSonido();
        }
    }
}