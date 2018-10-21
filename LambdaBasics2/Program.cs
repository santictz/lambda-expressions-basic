using System;
using System.Collections.Generic;

namespace LambdaBasics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Hacemos una expresion lambda mas compleja
            List<int> numerosPares = numeros.FindAll((i) =>
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Es Par");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Es Impar");
                        return false;
                    }
                }
            );
            //Mostramos los numeros
            foreach (var n in numerosPares)
            {
                Console.WriteLine(n);
            }
        }
    }
}
