using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpdotnet
{
    class Numeros
    {
        public void numeros()
        {
            int i = 0, prom = 0, ing = 0;
            int alto = 0;
            int bajo = 100;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                try
                {
                    ing = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
                if ((ing < 0) || (ing > 100)){
                    Console.WriteLine("Numero fuera de rango. Ingrese nuevamente");
                } else
                {
                    prom += ing;
                    i++;
                    if (ing > alto)
                    {
                        alto = ing;
                    }                    
                    if (ing < bajo)
                    {
                        bajo = ing;
                    }                                       
                }
            } while (i < 10);
            prom /= 10;
            Console.WriteLine("************************");
            Console.WriteLine("El numero mas bajo es: " + bajo);
            Console.WriteLine("El numero mas alto es: " + alto);
            Console.WriteLine("El promedio de numeros ingresados es: " + prom);
        }
        
        

    }
}
