using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Rectangulo
    {
        static void Main(string[] args)
        {
            {
                const char Caract = 'X';
                const char Espaco = ' ';
                int Larg = 5, Comp = 10;
                for (int C = 1; C <= Comp; C++)
                Console.Write(Caract);
                Console.WriteLine();
                for (int L=1; L <= Larg; L++)
                {
                    Console.Write(Caract);
                    for (int W = 2; W <= Comp - 1; W++)
                    Console.Write(Espaco);
                    Console.WriteLine(Caract);
                }
                for (int C = 1; C <= Comp; C++)
                    Console.Write(Caract);
                Console.WriteLine();
            }

        }
    }
}
