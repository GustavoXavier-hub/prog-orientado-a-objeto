using System;

namespace Exercicio18
{
    class PesquisaLinear
    {
        static String ExisteLinear(int X, int[] A, int I)
        {
            {
                if (I == A.Length)
                return X + " Não existe no vector";
                else
                if (A[I] == X)
                return X + " existe na posição " + I;
                else
                return ExisteLinear(X, A, I + 1);
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 3, 8, 2, 19, 56, 20, 90 }; 
            Console.Write("Número a procurar ");
            int X = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine(ExisteLinear(X, A, 0));
        }
    }
}
