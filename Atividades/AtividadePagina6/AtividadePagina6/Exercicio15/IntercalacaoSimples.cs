using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class IntercalacaoSimples
    {
        static void Main(string[] args)
        {
            {
                int[] A = { 13, 21, 45, 63 };
                int N = A.Length;
                int[] B = { 1, 10, 25, 35, 55, 80, 90 }; 
                int M = B.Length; int[] C = new int[N + M]; 
                int I, J, K; I = J = K = 0; 
                while (I <= N - 1 && J <= M - 1)
                {
                    if (A[I] <= B[J]) // entrada if
                    {
                        C[K] = A[I]; I++;
                    }                 //saida 1 if 
                    else
                    {                 //entrada else
                        C[K] = B[J];
                        J++;
                    }                   //saida else
                } //fim while
                if (I > N - 1)
                {
                    for (int T = J; T <= M - 1; T++)
                    {
                        C[K] = B[T]; 
                        K++;
                    }    
                }
                else
                {
                    for (int T = I; T <= N - 1; T++)
                    {
                        C[K] = A[T];
                        K++;
                    }
                }
                for(K = 0; K <= N + M - 1; K++)
                Console.Write("{0, 3}", C[K]);
                Console.WriteLine();
            }
        }
    }
}
