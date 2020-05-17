using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            return Fibonacci(350);
        }

        public List<int> Fibonacci(int nMaxSerie)
        {
            List<int> listFibonacci = new List<int>();

            listFibonacci.Add(0);
            listFibonacci.Add(1);

            int nNumero = 0;
            do {
                nNumero = listFibonacci[listFibonacci.Count-2] + listFibonacci[listFibonacci.Count-1];

                if(nNumero <= nMaxSerie)
                    listFibonacci.Add(nNumero);              
            } while (nNumero < nMaxSerie);

            return listFibonacci;
        }

        public bool IsFibonacci(int numberToTest)
        {
            List<int> listFibonacci = Fibonacci(numberToTest);

            return listFibonacci.Contains(numberToTest);
        }
    }
}
