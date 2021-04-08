using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicicio17
{
    class MultiplicacaoRussa
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Multiplicando ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Multiplicador ");
                int Y = Convert.ToInt32(Console.ReadLine());
                int X1 = X, Y1 = Y, S = 0;
                while (X1 >= 1)
                {
                    if (X1 % 2 != 0)
                        S = S + Y1;
                    X1 = (X1 / 2);
                    Y1 = Y1 * 2;
                }
                Console.WriteLine("{0} x {1}= {2}", X, Y, S);

            }
        }

        }
}

