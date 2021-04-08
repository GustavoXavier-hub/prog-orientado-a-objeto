using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio28
{
    class MatrizTransposta
    {
        static void Main(string[] args)
        {
            {
                double[,] A = { { 13, 21, 45, 63 }, { 5, 0, 10, 80 } }; 
                int N = A.GetLength(0); 
                int M = A.GetLength(1);
                double[,] At = new double[M, N]; 
                int Ti = 0, Tj;
                for (int J = 0; J <= M - 1; J++)
                {
                    Tj = 0; 
                    for (int I = 0; I <= N - 1; I++)
                    {
                        At[Ti, Tj] = A[I, J]; Tj++;
                    }
                    Ti++;
                }
                for (Ti = 0; Ti <= M - 1; Ti++)
                {
                    for (Tj = 0; Tj <= N - 1; Tj++)
                    Console.Write("{0, 4}", At[Ti, Tj]); 
                    Console.WriteLine();
                }
            }
        }
    }
}
