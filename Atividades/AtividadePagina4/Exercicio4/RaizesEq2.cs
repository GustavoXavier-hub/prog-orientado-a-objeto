using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class RaizesEq2
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o coef. de x^2 "); 
                double A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o coef. de x "); 
                double B = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o coef. independente "); 
                double C = Convert.ToDouble(Console.ReadLine());
                double Disc = Math.Pow(B, 2) - 4 * A * C;
                if (Disc > 0)
                {
                    Console.WriteLine("x1={0:F2}", (-B + Math.Sqrt(Disc)) / (2 * A)); 
                    Console.WriteLine("x1={0:F2}", (-B - Math.Sqrt(Disc)) / (2 * A));
                }
                else if (Disc == 0)
                Console.WriteLine("x1=x2 {0} ", -B / (2 * A));
                else
                Console.WriteLine(" Raízes imaginárias");
            }

        }
    }
}
