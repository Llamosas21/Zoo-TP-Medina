using System;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace Zoologico
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Leon simba = new Leon();
            simba.EmitirSonido();
        }
    }
}