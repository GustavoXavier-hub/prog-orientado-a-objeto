using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class LeituraVectorDeMatrizes
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos produtos há? "); 
                int N = Convert.ToInt16(Console.ReadLine());
                double[][,] Produtos = new double[N][,];
                int[,] Nmat = new int[N, 2]; 
                int I;
                for (I = 0; I <= N - 1; I++)
                {
                    Console.Write("Quantas vendas para o produto {0}? ", I + 1);
                    Nmat[I, 0] = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Quantos dados para cada venda do produto " + "{0}? ", I + 1);
                    Nmat[I, 1] = Convert.ToInt16(Console.ReadLine());
                }
                I = 0;
                for (int P = 0; P <= N - 1; P++)
                {
                    Produtos[P] = new double[Nmat[I, 0], Nmat[I, 1]]; 
                    I++;
                }
                for (int P = 0; P <= N - 1; P++)
                {
                    Console.WriteLine("Produto {0}", P + 1);
                    for (I = 0; I <= Produtos[P].GetLength(0) - 1; I++)
                    for (int J = 0; J <= Produtos[P].GetLength(1) - 1; J++)
                        {
                            Console.Write("Dados para a linha {0} coluna {1}  = ", I + 1, J + 1);
                            Produtos[P][I, J] = Convert.ToDouble(Console.ReadLine());
                        }
                    
                    }
                Console.WriteLine();
                for (int P = 0; P <= N - 1; P++)
                {
                    Console.WriteLine("Produto {0}", P + 1);
                    for (I = 0; I <= Produtos[P].GetLength(0) - 1; I++)
                    {
                        for (int J = 0; J <= Produtos[P].GetLength(1) - 1; J++)
                        {
                            Console.Write("{0, 6}", Produtos[P][I, J]);
                            Console.WriteLine();
                        }
                    }
                }

            }

            }

        }
    }

