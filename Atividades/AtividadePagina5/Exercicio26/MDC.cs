using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26
{
    class MDC
    {
        static void Main(string[] args)
        {

            {
                Console.Write("x="); 
                int X = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("y="); 
                int Y = Convert.ToInt16(Console.ReadLine()); 
                int X1 = X; int Y1 = Y;
                while (X1 != Y1)
                {
                    if (X1 > Y1) X1 -= Y1;
                    else 
                    Y1 -= X1;
                }
                Console.WriteLine("m.d.c.({0},{1})={2}", X, Y, X1);
            }
        }
    }
}
