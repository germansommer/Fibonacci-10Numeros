using System;

namespace Csharpdotnet
{
    
    class Program        
    {
        
        static void Main(string[] args)
        {
            var fib = new Fibonacci();
            var num = new Numeros();
            Console.WriteLine("******Fibonacci******");
            Console.WriteLine("Ingrese un Numero:");
            int key = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci:");
            fib.fibonacci(key);
            Console.WriteLine("--------------------------");
            Console.WriteLine("*****10 Numeros*****");
            num.numeros();
        }
        

        
       
    }

    
    
}
