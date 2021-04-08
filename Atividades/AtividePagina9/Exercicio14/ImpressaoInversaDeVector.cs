using System;

namespace Exercicio14
{
    class ImpressaoInversaDeVector
    {
        static void ImpressaoInversa(int[] A, int I)
        {
            {
                if (I < 0) 
                Console.WriteLine();
                else
                {
                    Console.Write("{0, 5}", A[I]); 
                    ImpressaoInversa(A, I - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            {
                int[] A = { 35, 45, 23, 78, 90, 65, 78, 90, 76, 34, 25, 100 }; int N = A.Length; ImpressaoInversa(A, N - 1);
            }
        }
    }
}
