using System;

namespace ConsoleApp1
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 10);
            int aleatorio2 = dado.Next(11, 20);
            Console.WriteLine("El número del primer dado es {0}, el del segundo dado es {1}.", aleatorio1, aleatorio2);
            
        }
    }
}
