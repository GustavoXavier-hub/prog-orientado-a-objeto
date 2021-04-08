using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class DeteccaoDeDoisErros
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.Write("Dividendo? ");
                    int X = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Divisor? ");
                    int Y = Convert.ToInt16(Console.ReadLine()); 
                    Console.WriteLine(X / Y);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Estamos à espera de números inteiros");
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("O divisor tem de ser diferente de zero");
                }
            }
        }
    }
}
