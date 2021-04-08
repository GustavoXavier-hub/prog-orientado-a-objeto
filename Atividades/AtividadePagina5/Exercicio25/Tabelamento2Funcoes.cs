using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class Tabelamento2Funcoes
    {
        static void Main(string[] args)
        {

            {
                double Y, F, Termo; Console.Clear();
                Console.WriteLine("{0,3}{1, 11} {2,10 }", "x", "sen(x)", "f(x)");
                for (double X = 5; X <= 10; X += 0.5)
                {
                    Y = Math.Sin(X); 
                    F = 0; 
                   for (int T = 1; T <= 20; T++)
                    {
                     Termo = 1 / (T * Math.Pow(X, T - 1));
                      F += Termo;
                    }
                    Console.WriteLine("{0,4:F1}{1, 10:F3} {2, 10:F3}", X, Y, F);
                }

            }
        }
    }
}
