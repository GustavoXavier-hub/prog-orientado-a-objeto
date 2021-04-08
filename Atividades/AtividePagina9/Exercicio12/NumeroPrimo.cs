using System;

namespace Exercicio12
{
    class NumeroPrimo
    {
        static Boolean Primo(int N, int Div)
        {
            {
                if (N == 1)
                    return false;
                else
                if (N == 2)
                    return true;
                else
                if (Div > (int)Math.Sqrt(N))
                    return true;
                else
                if (N % Div == 0)
                    return false;
                else
                    return Primo(N, Div + 1);
            }
        }
        static void Main(string[] args)
        {
            {
                Console.Write("Digite um inteiro ");
                int N = Convert.ToInt16(Console.ReadLine());
                int Div = 2; Console.WriteLine("{0} {1}", N, Primo(N, Div) ? "Primo" : "Não primo");
            }
        }
    }
}

