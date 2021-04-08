using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class LeituraEscritaMatriz
    {
        static void Main(string[] args)
        {

            {
                int N, M, Total;
                Console.Write("Quantas linhas tem a matriz? ");
                N = Convert.ToInt16(Console.ReadLine());
                Console.Write("Quantas colunas tem a matriz? ");
                M = Convert.ToInt16(Console.ReadLine());
                int[,] A = new int[N, M];
                for (int I = 0; I <= N - 1; I++)
                for (int J = 0; J <= M - 1; J++)
                {
                Console.Write("Elemento a [{0},{1}]? ", I, J);
                A[I, J] = Convert.ToInt16(Console.ReadLine());
                }
                 Console.WriteLine();
                for (int I = 0; I <= N - 1; I++)
                {
                    for (int J = 0; J <= M - 1; J++)
                    Console.Write("{0,4}", A[I, J]);
                    Console.WriteLine();
                }
             }
        }
    }

}
    

