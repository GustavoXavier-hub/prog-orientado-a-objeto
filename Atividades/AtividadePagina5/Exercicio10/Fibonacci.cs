using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            {
                int Fcorrente; 
                int Fult = 1;
                int Fpenult = 1;
                Console.WriteLine("F{0, 2:d}={1, 5:d}", 1, Fpenult); 
                Console.WriteLine("F{0, 2:d}={1, 5:d}", 2, Fult);
                for (int N = 3; N <= 20; N++)
                {
                Fcorrente = Fult + Fpenult; 
                Console.WriteLine("F{0, 2:d}={1, 5:d}", N, Fcorrente);
                Fpenult = Fult;
                Fult = Fcorrente;
                }
            }
        }
    }
}
