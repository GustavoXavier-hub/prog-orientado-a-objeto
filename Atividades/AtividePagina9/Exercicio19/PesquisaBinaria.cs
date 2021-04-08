using System;

namespace Exercicio19
{
    class PesquisaBinaria
    {
        static String ExisteBinaria(int X, int[] A, int Inferior, int Superior)
        {
            {
                int Meio; 
                if (Inferior > Superior)
                return X + " não existe";
                else
                {
                    Meio = (Inferior + Superior) / 2; 
                    if (A[Meio] == X)
                   return X + " existe na posição " + Meio;
                    else
                    if (A[Meio] > X)
                    return ExisteBinaria(X, A, Inferior, Meio - 1);
                    else
                  return ExisteBinaria(X, A, Meio + 1, Superior);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 2, 3, 8, 19, 20, 56, 90 };
            Console.Write("Número a procurar "); 
            int X = Convert.ToInt16(Console.ReadLine()); 
            int Inferior = 0; 
            int Superior = A.Length - 1;
            Console.WriteLine(ExisteBinaria(X, A, Inferior, Superior));
        }
    }
}
