using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpdotnet
{
    class Factorial
    {
        public int factorial(int numero)
        {
            int val1, val2, fac;
            val1 = numero;
            val2 = val1 - 1;
            fac = numero;
            int i = numero;
            while (i > 1)
            {
                fac = fac * val2;
                val1 = val2 - 1;
                i--;
                if (i > 1)
                {
                    fac = fac * val1;
                    val2 = val1 - 1;
                    i--;
                }
            }
            return fac;
        }
    }
}
