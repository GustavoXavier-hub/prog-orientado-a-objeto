using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class OrdenacaoDecrescente
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos números tem a lista? ");
                int K = Convert.ToInt16(Console.ReadLine());
                double[] A = new double[K];
                double Temporaria;
                int N = K - 1, Indicemaior;
                for (int I = 0; I <= N; I++)
                {
                    Console.Write("{0} número? ", I + 1);
                    A[I] = Convert.ToDouble(Console.ReadLine());
                }
                for (int Pas = 0; Pas <= N - 1; Pas++)
                {
                    Indicemaior = Pas;
                    for (int I = Pas + 1; I <= N; I++)
                        if (A[I] > A[Indicemaior])
                            Indicemaior = I;
                    if (Indicemaior != Pas)
                    {
                        {
                            Temporaria = A[Pas];
                            A[Pas] = A[Indicemaior];
                            A[Indicemaior] = Temporaria;
                        }
                    }

                }
                Console.WriteLine("\nLista ordenada:"); 
                for (int I = 0; I <= N; I++) 
                Console.WriteLine(A[I]);
            }
            
            }
        }
    }

