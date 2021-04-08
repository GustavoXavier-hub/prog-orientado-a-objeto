using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class SomatorioLinhasColunas
    {
        static void Lermatriz(int[,] A)
        {
            {
                for (int I = 0; I <= A.GetLength(0) - 2; I++) 
                for (int J = 0; J <= A.GetLength(1) - 2; J++)
                    {
                        Console.Write("Elemento A [{0},{1}]? ", I, J);
                        A[I, J] = Convert.ToInt16(Console.ReadLine());
                    }
            }
        }
        static void Somarlinhas(int[,] A)
        {
            int Total; 
            for (int I = 0; I <= A.GetLength(0) - 2; I++)
            {
                Total = 0; 
                for (int J = 0; J <= A.GetLength(1) - 2; J++) 
                Total += A[I, J];
                A[I, A.GetLength(1) - 1] = Total;
            }
        }
        static void Somarcolunas(int[,] A)
        {
            int Total; 
            for (int J = 0; J <= A.GetLength(1) - 2; J++)
            {
                Total = 0; 
                for (int I = 0; I <= A.GetLength(0) - 2; I++)
                Total += A[I, J];
                A[A.GetLength(0) - 1, J] = Total;
            }
        }
        static void Escrevermatriz(int[,] A)
        {
            for (int I = 0; I <= A.GetLength(0) - 1; I++)
            {
                for (int J = 0; J <= A.GetLength(1) - 1; J++)
                {
                    if (I != A.GetLength(0) - 1 || J != A.GetLength(1) - 1)
                    Console.Write("{0,5}", A[I, J]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int N, M, Total;
            Console.Write("Quantas linhas tem a matriz? ");
            N = Convert.ToInt16(Console.ReadLine()); 
            Console.Write("Quantas colunas tem a matriz? "); 
            M = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[N + 1, M + 1]; 
            Lermatriz(A); Somarlinhas(A);
            Somarcolunas(A);
            Escrevermatriz(A);
        }
    }
}
