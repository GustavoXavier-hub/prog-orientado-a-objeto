using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicicio19
{
    class AnosDeCapitalizacao
    {
        static void Main(string[] args)
        {

            {
                const double Taxa = 2.5; 
                Console.Write("Capital Inicial? "); 
                double Inicial = Convert.ToInt32(Console.ReadLine()); 
                double Meta = Inicial * 1.2, Acumu = 0; 
                int N = 0; 
                do
                {
                    Acumu = Math.Round(Inicial * Math.Pow((1 + Taxa / 100), N), 2);
                }
                while (Acumu <= Meta);
                Console.WriteLine("{0} EUR ao fim de {1} anos", Acumu, N);
            }

        }
    }
}
