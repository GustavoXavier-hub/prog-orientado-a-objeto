using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Contagens
    {
        static void Leitura(int[] A)
        {
            {
                for (int I = 0; I <= A.Length - 1; I++)
                {
                    Console.Write("Número {0}=", I + 1); 
                    A[I] = Convert.ToInt16(Console.ReadLine());
                }
            }
        }
        static void Contagem(int[] A, int[] Conta)
        {
            {
                for (int I = 0; I <= A.Length - 2; I++)
                {
                    if (Conta[I] != 0)
                    {
                        for (int J = I + 1; J <= Conta.Length - 1; J++)
                        {
                            if (A[I] == A[J])
                            {
                                Conta[I]++; Conta[J] = 0;
                            }
                        }
                    }
                }

            }
        }
        static void Escrita(int[] A, int[] Conta)
        {
            {
                for (int I = 0; I <= Conta.Length - 1; I++)
                    if (Conta[I] != 0)
                    Console.WriteLine("{0} ocorre {1} vez(es) no vector", A[I], Conta[I]);
            }
        }
        static void Main(string[] args)
        {
            {
                int[] A = new int[7]; 
                int[] Conta = new int[7]; 
                for (int I = 0; I <= A.Length - 1; I++)
                    Conta[I] = 1; 
                Leitura(A); 
                Contagem(A, Conta); 
                Escrita(A, Conta);
            }
        }
    }
}
