using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class RaizesQuadradas
    {
        static void Main(string[] args)
        {
            int Inf, Sup; Inf = 1;
            Sup = 20; RaizesQuad(Inf, Sup);
            Inf = 25; Sup = 40; RaizesQuad(Inf, Sup);
            Inf = 100; Sup = 120; RaizesQuad(Inf, Sup);
        }
        static void RaizesQuad(int Inf, int Sup)
        {
            {
                for (int I = Inf; I <= Sup; I++)
                {
                    Console.Write("{0,5:F1} ", Math.Sqrt(I));
                    Console.WriteLine();
                }
            }
        }
    }
}
