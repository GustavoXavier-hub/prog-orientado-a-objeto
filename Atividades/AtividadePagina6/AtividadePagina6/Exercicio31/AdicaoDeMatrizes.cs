using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio31
{
    class AdicaoDeMatrizes
    {
        static void Main(string[] args)
        {
            {

                int[,] A = { { 0, 1, 0 }, { 4, 0, 2 }, { 6, 3, 3 } }; 
                int[,] B = { { 1, 0, 1 }, { -1, 2, -2 }, { 1, -3, 3 } }; 
                int N = A.GetLength(0); int M = A.GetLength(1); 
                int[,] C = new int[N, M];
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                 C[I, J] = A[I, J] + B[I, J];
                for (int I = 0; I <= N - 1; I++)
                {
                    for (int J = 0; J <= M - 1; J++)
                    Console.Write("{0, 4}", C[I, J]); 
                    Console.WriteLine();
                }
            }
        }
    }
}
