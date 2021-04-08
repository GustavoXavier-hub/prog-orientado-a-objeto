using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class SomatorioEmColuna
    {
        static void Main(string[] args)
        {
            {
                int N, M; 
                double Total; 
                Console.Write("Quantas linhas tem a matriz? ");
                N = Convert.ToInt16(Console.ReadLine());
                Console.Write("Quantas colunas tem a matriz? "); 
                M = Convert.ToInt16(Console.ReadLine()); 
                double[,] A = new double[N + 1, M];
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                    {
                        Console.Write("Elemento a[{0},{1}]? ", I, J);
                        A[I, J] = Convert.ToDouble(Console.ReadLine());
                    }
                for (int J = 0; J <= M - 1; J++)
                {
                    Total = 0;
                    for (int I = 0; I <= N - 1; I++) 
                    Total += A[I, J];
                    A[N, J] = Total;
                }
                Console.WriteLine();
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
