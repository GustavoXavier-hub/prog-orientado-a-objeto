using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Factorial
    {
        static void Main(string[] args)
        {
            {
                int N; 
                Console.Write("Digite um inteiro positivo "); 
                N = Convert.ToInt16(Console.ReadLine());
                int Fact = 1;
                for (int M = N; M >= 1; M--)
                    Fact *= M;
                Console.WriteLine("{0}!={1}", N, Fact);
            }
        }
    }
}
