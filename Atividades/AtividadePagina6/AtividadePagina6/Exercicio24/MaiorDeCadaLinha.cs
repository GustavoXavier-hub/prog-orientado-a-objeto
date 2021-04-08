using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    class MaiorDeCadaLinha
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantas linhas tem a matriz? "); 
                int N = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Quantas colunas tem a matriz? "); 
                int M = Convert.ToInt16(Console.ReadLine()); 
                double[,] A = new double[N, M + 1]; 
                int Colmax;
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                    {
                        Console.Write("A[{0},{1}]=", I, J);
                        A[I, J] = Convert.ToDouble(Console.ReadLine());
                    }
                for (int I = 0; I <= N - 1; I++)
                { 
                    Colmax = 0;
                for (int J = 1; J <= M - 1; J++) 
                if (A[I, J] > A[I, Colmax])
                 Colmax = J; A[I, M] = A[I, Colmax]; 
                }
                for (int I = 0; I <= N - 1; I++)
                {
                    for (int J = 0; J <= M - 1; J++) 
                   Console.Write("{0, 5}", A[I, J]); 
                   Console.WriteLine("|{0, 5}", A[I, M]);
                }

            }
        }
    }
}
