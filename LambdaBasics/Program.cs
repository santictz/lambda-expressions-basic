using System;
using System.Collections.Generic;

namespace LambdaBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de parametros => instrucciones a realizar
            //Se puede usar donde se haga uso de un metodo anonimo
            //El tipo de parametros puede ser explicito o implicito

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Hacemos uso de la expresion lambda
            List<int> numerosPar = numeros.FindAll(i => (i %2) == 0);

            //Mostramos los números
            foreach(int n in numerosPar)
            {
                Console.WriteLine(n);
            }

        }
    }
}
