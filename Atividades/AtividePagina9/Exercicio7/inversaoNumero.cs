using System;

namespace Exercicio7
{
    class inversaoNumero
    {
        static void Inversao(int N)
        {
            {
                if (N > 0)
                {
                    Console.Write(N % 10);
                    Inversao(N / 10);
                }
            }
        }
        static void Main(string[] args)
        {
            {
                int N = 654321; Inversao(N); 
                Console.WriteLine("\n");
            }
        }
    }
}
