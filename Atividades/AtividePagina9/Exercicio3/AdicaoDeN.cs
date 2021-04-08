using System;

namespace Exercicio3
{
    class AdicaoDeN
    {
        static long AdicaoN(int N)
        {
            {
                if (N == 0) 
               return 0; 
                else 
               return N + AdicaoN(N - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Maior inteiro a somar "); 
            int N = Convert.ToInt16(Console.ReadLine());
            long Total = AdicaoN(N); 
            Console.WriteLine("Total da adição dos {0} primeiros " + "inteiros={1}", N, Total);
        }
    }
}
