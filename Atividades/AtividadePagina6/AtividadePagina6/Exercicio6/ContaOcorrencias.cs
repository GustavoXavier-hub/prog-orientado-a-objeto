using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class ContaOcorrencias
    {
        static void Main(string[] args)
        {
            {
                int[] A = { 4, 2, 5, 4, 3, 5, 2, 2, 4 }; 
                int N = A.Length - 1; 
                int[] Conta = new int[N + 1]; 
                for (int I = 0; I <= N - 1; I++)
                    Conta[I] = 1;
                for (int I = 0; I < N - 1; I++)
                {
                   if (Conta[I] != 0)
                    {
                        for (int J = I + 1; J <= N; J++)
                        {
                            if (A[I] == A[J])
                                Conta[I]++; 
                            Conta[J] = 0;
                        }
                    }
                }
                for (int I = 0; I <= N; I++)
                if (Conta[I] != 0)
                Console.WriteLine(" {0, 4} ocorre {1, 2} vez(es)em A", A[I], Conta[I]);
            }
        }
    }
}
