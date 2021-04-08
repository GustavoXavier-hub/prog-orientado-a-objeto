using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class HorasMinutosSegundos
    {
        static int Segundos(int Seg)
        {
            {
                return Seg % 60;
            }
        }
        static int Minutos(int Seg)
        {
            {
                return (Seg / 60) % 60;
            }
        }

        static int Horas(int Seg)
        {
            {
                return (Seg / 60) / 60;
            }
        }

        static void Main(string[] args)
        {
            {
                Console.Write("Digite o número de segundos a converter ");
                int Seg = Convert.ToInt32(Console.ReadLine());
                int H = Horas(Seg);
                int M = Minutos(Seg);
                int S = Segundos(Seg);
                Console.WriteLine("{0}={1}:{2}:{3}", Seg, H, M, S);
            }
        }
    }
}
