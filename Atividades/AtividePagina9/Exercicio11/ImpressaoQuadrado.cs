using System;

namespace Exercicio11
{
    class ImpressaoQuadrado
    {
        static String Quadrado(int N, int I, int J, char C1)
        {
            {
                if (I < 0)
                {
                    return "\n";
                }
                else
                {
                    if (J <= N - 1) 
                   return C1 + Quadrado(N, I, J + 1, C1);
                   else 
                  return "\n" + Quadrado(N, I - 1, 0, C1);
                }
            }
        }
        static void Main(string[] args)
        {

            char C1 = '*'; int N = 6; Console.WriteLine(Quadrado(N, N - 1, 0, C1));
        }
    }
}
