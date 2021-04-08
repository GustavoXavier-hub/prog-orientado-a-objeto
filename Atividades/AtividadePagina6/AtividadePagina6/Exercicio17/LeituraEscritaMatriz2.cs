using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class LeituraEscritaMatriz2
    {
        static void Main(string[] args)
        {
            {
                int N = 0, M, Linha = 0; Console.Write("Quantas colunas tem a matriz? ");
                M = Convert.ToInt16(Console.ReadLine()); 
                string[,] A = new string[100, M];
                Console.Write("Elemento a [{0},0] ou ZZZ? ", Linha);
                A[Linha, 0] = Console.ReadLine();
                while (A[Linha, 0].ToUpper() != "ZZZ")
                {
                    for (int Coluna = 1; Coluna <= M - 1; Coluna++)
                    {
                        Console.Write("Elemento a [{0},{1}]? ", Linha, Coluna);
                        A[Linha, Coluna] = (Console.ReadLine());
                    }
                    Linha++;
                    Console.Write("Elemento a [{0},0] ou ZZZ? ", Linha);
                    A[Linha, 0] = Console.ReadLine();
                }
                N = Linha;
                Console.WriteLine();
                for (Linha = 0; Linha <= N - 1; Linha++)
                {
                    for (int Coluna = 0; Coluna <= M - 1; Coluna++)
                    Console.Write("{0,10}", A[Linha, Coluna].PadRight(10)); 
                    Console.WriteLine();
                }

            }

        }
    }
}
