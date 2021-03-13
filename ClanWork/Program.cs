using System;

namespace ClanWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Ingrese un valor entero a 'a': "); //Se solicita al usuario que ingrese 
            a = Convert.ToInt32(Console.ReadLine());              // un valor entero cualquiera para la variable 'a'
            Console.WriteLine("Ingrese un valor entero a 'b': "); // y de igual manera para la variable 'b' desde teclado
            b = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine($"La suma de {a} + {b} da como resultado: {AddNumbers(a,b)}");

        }

        public static int AddNumbers(int a, int b)
        {
            return a+b;
        }
    }
}
