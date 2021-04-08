using System;

namespace Exercicio17
{
    class MaiorNumero
    {
        static int Maior(int[] A, int Inferior, int Superior)
        {
            int Meio, Esquerda, Direita; 
            if (Inferior == Superior) 
            return A[Inferior];
            else
            {
                Meio = (Inferior + Superior) / 2; 
                Esquerda = Maior(A, Inferior, Meio);
                Direita = Maior(A, Meio + 1, Superior);
                if (Esquerda > Direita)
                return Esquerda;
                else
                return Direita;
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 1203, 67, 89, 124, 12, 156 };
            Console.WriteLine("Maior elemento={0}", Maior(A, 0, A.Length - 1));
        }
    }
}
