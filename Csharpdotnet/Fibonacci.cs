using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpdotnet
{
    class Fibonacci
    {
        public void fibonacci(int iteraciones)
        {
            int val1, val2, fib;
            val1 = 0;
            val2 = 1;
            fib = 0;
            int i = 0;
            while (i < iteraciones)
            {
                fib = val1 + val2;
                val1 = fib;
                Console.WriteLine(fib);
                i++;
                if (i < iteraciones)
                {
                    fib = val1 + val2;
                    val2 = fib;
                    Console.WriteLine(fib);
                    i++;
                }
            }
        }
    }
}
