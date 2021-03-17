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

            //Console.WriteLine($"La suma de {a} + {b} da como resultado: {AddNumbers(a,b)}");
            Console.WriteLine($"La diferencia de {a} - {b} da como resultado: {SubtractNumbers(a,b)}"); //cambiando a multiplicación 

 // Console.WriteLine($"La diferencia de {a} - {b} da como resultado: {SubtractNumbers(a,b)}"); 
 // --> (cambiando de multiplicacion a resta)

        }

        public static int SubtractNumbers(int a, int b)
        {
            return a-b; // Se cambio de multiplicacion a resta 
        }
    }
}
