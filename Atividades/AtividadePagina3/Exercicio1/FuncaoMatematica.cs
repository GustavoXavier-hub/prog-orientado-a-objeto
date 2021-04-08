using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class FuncaoMatematica
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Digite o valor de X="); 
                double X = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Digite o valor de Y="); double Y = Convert.ToDouble(Console.ReadLine());
                double F = (Y + Math.Sqrt(Math.Abs(2 * X + 10))) / (2 * X);
                Console.WriteLine("F({0},{1})={2:F3}", X, Y, F);
            }
        }
    }
}
