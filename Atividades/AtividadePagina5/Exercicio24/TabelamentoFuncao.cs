using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    class TabelamentoFuncao
    {
        static void Main(string[] args)
        {
            {
                int Y = 0; Console.Clear(); 
                Console.WriteLine("{0,3}{1, 11}", "x", "f(x)");
                for (int X = 1; X <= 20; X += 2)
                {
                    if (X < 12)
                    Y = X - 4;
                    else
                    if (X < 15)
                    Y = 10;
                    else
                    Y = X + 4; 
                    Console.WriteLine("{0,4:F1}{1, 10:F3}", X, Y);
                }

            }
        }
    }
}
