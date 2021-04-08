using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class MenorDeCadaColuna
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantas linhas tem a matriz? ");
                int N = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Quantas colunas tem a matriz? ");
                int M = Convert.ToInt16(Console.ReadLine()); 
                int[,] A = new int[N + 1, M];
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                    {
                        Console.Write("A[{0},{1}]=", I, J); 
                        A[I, J] = Convert.ToInt16(Console.ReadLine());
                    }
                int Linmin;
                for (int J = 0; J <= M - 1; J++)
                {
                    Linmin = 0; 
                    for (int I = 1; I <= N - 1; I++) 
                    if (A[I, J] < A[Linmin, J]) 
                            Linmin = I;
                    A[N, J] = A[Linmin, J];
                }
                for (int I = 0; I <= N - 1; I++)
                {
                    for (int J = 0; J <= M - 1; J++) 
                   Console.Write("{0, 6}", A[I, J]); 
                    Console.WriteLine();
                }
                for (int J = 0; J <= M - 1; J++) 
                Console.Write("{0, 6}", "-");
                Console.WriteLine();
                for (int J = 0; J <= M - 1; J++)
                Console.Write("{0, 6}", A[N, J]); 
                Console.WriteLine();
            }
        }
    }
}
