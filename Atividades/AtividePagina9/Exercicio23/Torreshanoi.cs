using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    class Torreshanoi
    {
        static void Hanoi(int Altura, char De, char Para, char Usando)
        {
            {
                if (Altura == 1) 
                Console.WriteLine("Mudar o disco de {0} para {1}", De, Para);
                else
                {
                    Hanoi(Altura - 1, De, Usando, Para); 
                    Console.WriteLine("Mudar o disco de {0} para {1}", De, Para);
                    Hanoi(Altura - 1, Usando, Para, De);
                }
            }
        }
        static void Main(string[] args)
        {
            int Altura = 4; Hanoi(Altura, 'A', 'C', 'B');
        }
    }
}
