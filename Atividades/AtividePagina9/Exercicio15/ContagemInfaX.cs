using System;

namespace Exercicio15
{
    class ContagemInfaX
    {
        static int Contagem(int[] A, int X, int I)
        {
            {
                int Conta = 0; 
                if (I >= 0)
                {
                    if (A[I] < X)
                    Conta++; 
                    Conta += Contagem(A, X, I - 1);
                }
                return Conta;
            }
        }
        static void Main(string[] args)
        {
            int N = 12; int[] A = { 35, 45, 23, 78, 90, 65, 78, 90, 76, 34, 25, 100 }; 
            Console.Write("Digite o limite superior da contagem "); 
            int X = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Número de elementos inferiores a {0}={1}", X, Contagem(A, X, N - 1));
        }
    }
}
