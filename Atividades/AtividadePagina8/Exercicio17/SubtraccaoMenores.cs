using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class SubtraccaoMenores
    {
        static void Ler(int[,] A)
        {
            for (int I = 0; I <= A.GetLength(0) - 1; I++)
            {
                for (int J = 0; J <= A.GetLength(1) - 1; J++)
                {
                    Console.Write("Digite o elemento A[{0},{1}] ", I, J);
                    A[I, J] = Convert.ToInt16(Console.ReadLine());
                }
            }
        }
        static void Escrever(int[,] A)
        {
            for (int I = 0; I <= A.GetLength(0) - 1; I++)
            {
                for (int J = 0; J <= A.GetLength(1) - 1; J++)
                {
                    Console.Write("{0, 4}", A[I, J]); 
                    Console.WriteLine();
                }
            }
        }

        static void Subtrair(int[,] A)
        {
            int Menor; 
            for (int I = 0; I <= A.GetLength(0) - 1; I++)
            {
                Menor = MenorLinha(I, A); 
                for (int J = 0; J <= A.GetLength(1) - 1; J++) 
                A[I, J] -= Menor;
            }
        }
        static int MenorLinha(int I, int[,] A)
        {
            int Menor = 0;
            for (int J = 1; J <= A.GetLength(1) - 1; J++) 
            if (A[I, Menor] > A[I, J])
            Menor = J;
            return A[I, Menor];
        }
        static void Main(string[] args)
        {
            int N = 3;
            int[,] A = new int[N, N];
            Ler(A); 
            Subtrair(A);
            Escrever(A);
        }
    }
}
