using System;

namespace Exercicio16
{
    class Vectores
    {
        static int Somatorio(int[] A, int I)
        {
            {
                int Total = 0; 
                if (I == 0) 
               return Total += A[I];
              else return Total += A[I] + Somatorio(A, I - 1);
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 35, 45, 23, 78, 90, 65, 78, 90, 76, 34, 25, 100 };
            Console.WriteLine("Somatório dos elementos do vector={0}", Somatorio(A, A.Length - 1));
        }
    }
}
