using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio34
{
    class TrianguloPascal
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Altura do triângulo? ");
                int N = Convert.ToInt16(Console.ReadLine()); 
                long[,] T = new long[N * 2 + 1, N * 2 + 1];
                int Meio = (0 + 2 * N) / 2; T[0, Meio] = 1;
                for (int I = 1; I <= Meio - 1; I++) 
                for (int J = Meio - I; J <= Meio + I; J = J + 2)
                T[I, J] = T[I - 1, J - 1] + T[I - 1, J + 1]; 
                for (int I = 0; I <= Meio - 1; I++)
                {
                    Console.WriteLine(); 
                    for (int J = 0; J <= N * 2; J++)
                        if (T[I, J] != 0)
                    Console.Write("{0, 3}", T[I, J]);
                        else
                    Console.Write("{0, 3}", "");
                    Console.WriteLine();
                }
            }
        }
    }
}
