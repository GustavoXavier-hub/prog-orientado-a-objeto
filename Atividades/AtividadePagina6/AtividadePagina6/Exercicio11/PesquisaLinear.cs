using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class PesquisaLinear
    {
        static void Main(string[] args)
        {
            {
                int X, N = 10, I; 
                int[] A = new int[N + 1];
                for (I = 0; I <= N - 1; I++)
                A[I] = 200 - 100 * I + 150; 
                Console.Write("Digite o valor a procurar ");
                X = Convert.ToInt16(Console.ReadLine()); 
                A[N] = X;
                I = 0;
                while (A[I] != X)
                I++; 
                if (I != N)
                    Console.WriteLine("{0} é o elemento índice {1} do vector", X, I);
                else
                    Console.WriteLine("{0} não existe no vector!!", X);
            }
        }
    }
}
