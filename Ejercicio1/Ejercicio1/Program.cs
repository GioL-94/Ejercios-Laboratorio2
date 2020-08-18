using System;

namespace Ejercicio1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int milisec = DateTime.Now.Millisecond;
            int dado = milisec % 100 + 1;
            Console.WriteLine("El número al azar es: {0}.", dado);
        }
    }
}
