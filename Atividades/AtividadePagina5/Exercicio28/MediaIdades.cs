using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio28
{
    class MediaIdades
    {
        static void Main(string[] args)
        {

            {
                double Med = 0;
                int N = 0; 
                Console.Write("Idade do paciente (999 para terminar) ");
                int Idade = Convert.ToInt16(Console.ReadLine());
                while (Idade != 999)
                {
                    N++;
                    Med+= Idade;
                    Console.Write("Idade do paciente (999 para terminar) ");
                    Idade = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Media das idades das {0} pessoas=" + "{1,4:F2} anos", N, Med / N);
            }
        }
    }
}
