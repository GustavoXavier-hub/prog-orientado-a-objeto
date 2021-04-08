using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class LeituraMatriz3D
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Tamanho 1. dimensão "); 
                int T = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Tamanho 2. dimensão ");
                int N = Convert.ToInt16(Console.ReadLine());
                Console.Write("Tamanho 3. dimensão ");
                int M = Convert.ToInt16(Console.ReadLine());
                string[,,] A = new string[T, N, M];
                for (int P = 0; P <= T - 1; P++)
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                {
                 Console.Write("a[{0},{1},{2}]=", P, I, J); 
                   A[P, I, J] = Console.ReadLine();
                }
                for (int P = 0; P <= T - 1; P++)
                {
                    Console.WriteLine("Escola {0}", P);
                    for (int I = 0; I <= N - 1; I++)
                    {
                        for (int J = 0; J <= M - 1; J++)
                        Console.Write(A[P, I, J].PadRight(12)); 
                        Console.WriteLine();
                    }
                }

            }

        }
    }
}
