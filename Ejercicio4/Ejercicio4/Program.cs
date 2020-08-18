using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numero;
            int aleatorio = r.Next(1, 10000);
            int contador = 12;
            Console.WriteLine(aleatorio);
            Console.WriteLine("Ingresa el número que pensas que es");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero != aleatorio && contador > 0)
            {
                
                    if (numero < aleatorio)
                    {
                        Console.WriteLine("Corto");
                        numero = Convert.ToInt32(Console.ReadLine());
                        contador--;
                    }
                    if(numero > aleatorio)
                    {
                        Console.WriteLine("Pasado");
                        numero = Convert.ToInt32(Console.ReadLine());
                        contador--;
                    }   
            }
            if (numero == aleatorio)
            {
                Console.WriteLine("Has acertado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Lo lamentamos el numero era {0}", aleatorio);
                Console.ReadKey();
            }
            
        }
    }
}
