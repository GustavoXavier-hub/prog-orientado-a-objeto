using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class SomaEProdutoDigitos
    {
        static void Main(string[] args)
        {

            {
                int Nd, Soma, Prod, X, Expoente, Dig;
                for (int N = 100; N <= 999; N++)
                {
                    Nd = (int)Math.Log10(N) + 1; Soma = 0; 
                    Prod = 1; X = N; Expoente = Nd - 1;

                    for (int D = 1; D <= Nd; D++)
                    {
                        Dig = X / (int)Math.Pow(10, Expoente);
                        Soma += Dig; 
                        Prod *= Dig; 
                        X -= Dig * (int)Math.Pow(10, Expoente);
                        Expoente--;
                    }
                    if (Soma == Prod)
                       Console.WriteLine(N);
                }
            }
        }
    }
}
