using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio33
{
    class Determinante
    {
        static void Main(string[] args)
        {
            {
                double[,] A = { { 1, 2, 3 }, { 3, 1, 4 }, { 0, 1, 2 } };
                double[,] Alg = new double[A.GetLength(0), A.GetLength(1) + 2];
                int K = 0;
                double D = 0, D1 = 0, D2 = 0, Prod;
                for (int I = 0; I <= A.GetLength(0) - 1; I++)
                {
                    K = 0; 
                    for (int J = 0; J <= A.GetLength(1) + 1; J++)
                    {
                        if (K == A.GetLength(1))
                         K = 0; 
                        Alg[I, J] = A[I, K];
                        K++;
                    }
                }
                for (int Dg = 0; Dg <= Alg.GetLength(0) - 1; Dg++)
                {
                    K = Dg; 
                    Prod = 1;
                    for (int I = 0; I <= Alg.GetLength(0) - 1; I++)
                    {
                        Prod = Prod * Alg[I, K]; 
                        K++;
                    }
                    D1 += Prod;
                }
                for (int Dg = Alg.GetLength(1) - 1; Dg >= Alg.GetLength(1) - 3; Dg--)
                {
                    K = Dg;
                    Prod = 1;
                    for (int I = 0; I <= Alg.GetLength(0) - 1; I++)
                    {
                        Prod = Prod * Alg[I, K]; 
                        K--;
                    }
                    D2 += Prod;
                }
                D = D1 - D2; 
                Console.WriteLine("Determinante= {0, 2:F1}", D);
            }
        }
    }
}
