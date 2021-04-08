using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21
{
    class DigitoDeControlo
    {
        static void Main(string[] args)
        {
            {
                int Numero = Convert.ToInt32(Console.ReadLine());
                int N = Numero; int Total = 0; 
                int Nat = 1, Dig = 0;
                while (N > 0)
                {
                    Dig = N % 10; Total += Dig * Nat; N /= 10;
                    Nat++;
                }
                int Checkdigito = Total % 7; 
                int Codcheck = Numero * 10 + Checkdigito; 
                Console.WriteLine(Codcheck);
            }

        }
    }
}
