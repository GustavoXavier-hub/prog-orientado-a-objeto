using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicicio18
{
    class CapitalAcumulado
    {
        static void Main(string[] args)
        {

            {
                const int Anos = 3, Anoinicio = 2010; 
                const double Taxamin = 2, Taxamax = 3, Inicial = 1500; 
                double Acumu = 0; 
                Console.Write((Inicial.ToString() + "EUR").PadRight(8));
                for (double Taxa = Taxamin; Taxa <= Taxamax; Taxa += 0.5)
                Console.Write("{0,13:P1}", Taxa / 100);
                Console.WriteLine();
                for (int N = 1; N <= Anos; N++)
                {
                    Console.Write((Anoinicio + N).ToString().PadRight(8));

                    for (double Taxa = Taxamin; Taxa <= Taxamax; Taxa += 0.5)
                    {
                        Acumu = Math.Round(Inicial * Math.Pow((1 + Taxa / 100), N), 2);
                        Console.Write("{0, 13:F2}", Acumu);
                    }
                        Console.WriteLine();
                }
            }

            }

        }
    }

