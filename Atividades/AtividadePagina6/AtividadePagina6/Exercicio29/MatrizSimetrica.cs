using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio29
{
    class MatrizSimetrica
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantas linhas tem a matriz? ");
                int N = Convert.ToInt16(Console.ReadLine()); 
                int[,] A = new int[N, N];
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= I; J++)
                    {
                        Console.Write("A[{0},{1}]=", I, J); A[I, J] = Convert.ToInt16(Console.ReadLine()); if (I != J);
                        if (I != J)
                       A[J, I] = A[I, J];
                    }
                for (int I = 0; I <= N - 1; I++)
                {
                    for (int J = 0; J <= N - 1; J++)
                        Console.Write("{0, 5}", A[I, J]); 
                        Console.WriteLine();
                }
            }
        }
    }
}
