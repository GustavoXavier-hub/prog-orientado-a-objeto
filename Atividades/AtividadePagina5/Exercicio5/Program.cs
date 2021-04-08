using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const int Termos = 95;
                double P = 0;
                int Numerador = 1;
                int Denominador = 0;
                for (int T=1;  T <= Termos; T++)
                {
                    if (T % 2 == 0)
                        Numerador += 2;
                    else
                        Denominador += 2;
                    P += (double)Numerador / Denominador;
                }
                Console.WriteLine("P={0,    2:F2}",P);
            }

        }
    }
}
