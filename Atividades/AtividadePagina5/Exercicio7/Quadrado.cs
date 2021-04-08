using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Quadrado
    {
        static void Main(string[] args)
        {
            {

                const char Caract1 = 'X'; 
                const char Caract2 = 'O'; 
                const int N = 6;
                for (int I = 1; I <= N; I++)
                {
                    
                for (int J = 1; J <= N; J++)
                    if ((I + J) % 2 == 0)
                    Console.Write(Caract1);
                    else
                   Console.Write(Caract2);
                    Console.WriteLine();
                }
            }

        }
    }
}
