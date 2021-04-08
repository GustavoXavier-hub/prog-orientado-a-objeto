using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio32
{
    class MultiplicacaoDeMatrizes
    {
        static void Main(string[] args)
        {
            {
                int[,] A = { { 1, 2, 3 }, { 4, 0, 2 } };
                int N1 = A.GetLength(0);
                int M1 = A.GetLength(1); 
                int[,] B = { { 1, 0 }, { 2, 2 }, { 3, 3 } };
                int N2 = B.GetLength(0); 
                int M2 = B.GetLength(1);
                int[,] C = new int[N1, M2];
                int Total = 0;
                for (int I = 0; I <= N1 - 1; I++)
                {
                    for (int K = 0; K <= M2 - 1; K++)
                    {
                        Total = 0;
                        for (int J = 0; J <= M1 - 1; J++)
                        Total = Total + A[I, J] * B[J, K];
                        C[I, K] = Total;
                    }
                }
                for (int I = 0; I <= N1 - 1; I++)
                {
                    for (int J = 0; J <= M2 - 1; J++)
                    Console.Write("{0, 4}", C[I, J]);
                    Console.WriteLine();
                }
            }

        }
    }
}
