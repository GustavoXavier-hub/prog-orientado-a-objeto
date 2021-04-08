using System;

namespace Exercicio4
{
    class FactorialDeN
    {
        static long Factorial(int X)
        {
            {
                if (X == 0) 
                 return 1;
                else return X * Factorial(X - 1);
            }
        }
        static void Main(string[] args)
        {
            {
                Console.Write("Digite um numero inteiro positivo ");
                int N = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Factorial de {0}!={1}", N, Factorial(N));
            }

        }
    }
}
