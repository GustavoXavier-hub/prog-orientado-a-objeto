using System;

namespace Exercicio2
{
    class ContagemDecrescente
    {

        static void Contagem(int N)
        {
            {
                if (N == 0)
                Console.WriteLine(N);
                else
                {
                    Console.WriteLine(N); 
                    Contagem(N - 1);
                }
            }
        }

        static void Main(string[] args)
        {
            int N = 5; 
            Contagem(N);
        }
    }
}
