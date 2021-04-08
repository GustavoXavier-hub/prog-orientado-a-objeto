using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePagina7
{
    class DivisaoPorZero
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Dividendo? "); 
                int X = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Divisor? "); 
                int Y = Convert.ToInt16(Console.ReadLine());
                try
                {
                    Console.WriteLine(X / Y);
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("O divisor tem de ser diferente de zero");
                }
            }
        }
    }
}
