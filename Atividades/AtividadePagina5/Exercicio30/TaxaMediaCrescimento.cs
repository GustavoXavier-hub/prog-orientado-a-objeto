using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30
{
    class TaxaMediaCrescimento
    {
        static void Main(string[] args)
        {

            {
                double Medg = 1;
                double N = 0, F;
                Console.Write("Taxa de crescimento anual % (999 para" + "terminar) ");
                double Taxa = Convert.ToDouble(Console.ReadLine());
                while (Taxa != 999)
                {
                    {
                        N++; F = 1 + Taxa / 100;
                        Medg *= F;
                        Console.Write("Taxa de crescimento anual % (999 para" + "terminar) ");
                        Taxa = Convert.ToDouble(Console.ReadLine());
                    }
                    Medg = (Math.Pow(Medg, (1 / N)) - 1) * 100;
                   Console.WriteLine("Taxa média anual de crescimento nos {0}" + "anos={1,5:F2}%", N, Medg);
                }

            }
        }
    }
}
