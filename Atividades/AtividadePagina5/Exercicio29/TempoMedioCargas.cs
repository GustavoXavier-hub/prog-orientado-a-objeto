using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio29
{
    class TempoMedioCargas
    {
        static void Main(string[] args)
        {

            {
                double Medh = 0; int C = 0; 
                Console.Write("Tempo médio do camionista (0 para terminar) ");
                double Tempomed = Convert.ToInt16(Console.ReadLine());
                while (Tempomed != 0)
                { 
                    C++; 
                    Medh += 1 / Tempomed;
                    Console.Write("Tempo médio do camionista (0 para terminar)");
                    Tempomed = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Tempo médio por carga dos {0} camionistas" + "={1,4:F2} horas", C, C / Medh);
            }
        }
    }
}
