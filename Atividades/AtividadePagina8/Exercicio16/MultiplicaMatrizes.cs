using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class MultiplicaMatrizes
    {
        static void Main(string[] args)
        {
            {
                int[,] A = { { 1, 2, 3 }, { 4, 0, 2 } };
                int[,] B = { { 1, 0 }, { 2, 2 }, { 3, 3 } };
                int[,] C = Multiplica(A, B);
                for (int I = 0; I <= A.GetLength(0) - 1; I++)
                {
                    for (int J = 0; J <= B.GetLength(1) - 1; J++)
                        Console.Write("{0, 4}", C[I, J]); Console.WriteLine();
                }
            }
        }
        static int[,] Multiplica(int[,] A, int[,] B)
        {
            {
                int Total = 0; 
                int[,] C = new int[A.GetLength(0), B.GetLength(1)];
                for (int I = 0; I <= A.GetLength(0) - 1; I++)
                {
                    for (int K = 0; K <= B.GetLength(1) - 1; K++)
                    {
                        Total = 0; 
                        for (int J = 0; J <= A.GetLength(1) - 1; J++)
                        Total = Total + A[I, J] * B[J, K];
                        C[I, K] = Total;
                    }
                }
                return C;
            }
        }
    }



}
