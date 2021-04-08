using System;

namespace Exercicio5
{
    class FibonnaciDeN
    {
        static long Fibonacci(int X)
        {
            {
                if (X <= 2)
               return 1; 
                else 
               return Fibonacci(X - 1) + Fibonacci(X - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite a ordem do número de Fibonnaci que quer calcular ");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("F({0})={1}", N, Fibonacci(N));
        }
    }
}
