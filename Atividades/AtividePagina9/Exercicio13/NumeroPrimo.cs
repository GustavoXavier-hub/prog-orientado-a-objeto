using System;

namespace Exercicio13
{
    class Vectores
    {
        static void Impressao(int[] A, int I)
        {
            {
                Console.Write("{0, 5}", A[I]); 
                if (I == A.Length - 1)
                Console.WriteLine();
                else
                {
                    Console.Write(","); 
                    Impressao(A, I + 1);
                }
                
            }
        }
        public static void Main(string[] args)
        {
            int[] A = { 35, 45, 23, 78, 90, 65, 78, 90, 76, 34, 25, 100 }; Impressao(A, 0);
        }

    }
}
