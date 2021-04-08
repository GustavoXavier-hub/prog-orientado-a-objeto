using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26
{
    class ClassificacaoFinal
    {
        static void Main(string[] args)
        {
            {
                char[] Chave = { 'a', 'b', 'c', 'c', 'd', 'a' };
                int[] Cotacao = { 1, 2, 3, 3, 2, 2 }; 
                int M = Chave.Length; Console.Write("Quantos alunos há? ");
                int N = Convert.ToInt16(Console.ReadLine());
                char[,] Resp = new char[N, M]; 
                int[] Final = new int[N];
                for (int I = 0; I < N; I++)
                for (int J = 0; J < M; J++)
                    {
                        Console.Write("Resposta do aluno {0} à pergunta {1} ", I + 1, J + 1); 
                        Resp[I, J] = Convert.ToChar(Console.ReadLine());
                    }
                for (int I = 0; I < N; I++)
                {
                    Final[I] = 0;
                    for (int J = 0; J < M; J++)
                    if (Resp[I, J] == Chave[J])
                       Final[I] += Cotacao[J];
                    Console.WriteLine("\n {0,4} {1, 12}", "Aluno", "Classificação");
                    Console.WriteLine("{0, 4} {1,6}", I + 1, Final[I]);
                }

            }
        }
    }
}
