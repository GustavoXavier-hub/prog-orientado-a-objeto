using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    class NumerosPerfeitos
    {
        static void Main(string[] args)
        {
            {
                int Somadiv; Console.Write("N? "); 
                int N = Convert.ToInt32(Console.ReadLine());
                for (int I = 1; I <= N; I++)
                {
                    Somadiv = 0;
                    for (int D = 1; D <= I / 2; D++)
                        if (I % D == 0)
                        Somadiv += D;
                    if (I == Somadiv)
                  Console.WriteLine(I);
                }
            }
        }
    }
}
