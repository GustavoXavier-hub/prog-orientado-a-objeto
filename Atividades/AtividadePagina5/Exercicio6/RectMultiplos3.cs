using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class RectMultiplos3
    {
        static void Main(string[] args)
        {
            int L, C;
            Console.Write("Largura do rectângulo ");
            L = Convert.ToInt16(Console.ReadLine()); 
            Console.Write("Comprimento do rectângulo ");
            C = Convert.ToInt16(Console.ReadLine());
            int N = 9999;
            for (int Linha = 1; Linha <= L; Linha++)
            {
                for (int Coluna = 1; Coluna <= C; Coluna++)
                {
                    N += 3;
                    Console.Write("{0, 7:D3}", N);
                }
                Console.WriteLine("");
            }
        }
    }
}
