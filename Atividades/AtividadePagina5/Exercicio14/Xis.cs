using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Xis
    {
        static void Main(string[] args)
        {
            {
                const char Caract = 'X'; 
                const char Ponto = '.'; 
                int Dimensao = 12; Console.Clear();
                for (int Linha = 1; Linha <= Dimensao; Linha++)
                {
                    for (int Coluna = 1; Coluna <= Dimensao; Coluna++)
                    {
                        if ((Linha == Coluna) || (Coluna == Dimensao - Linha + 1))
                            Console.Write(Caract);
                            else
                            Console.Write(Ponto);
                    }
                    Console.WriteLine(); Console.WriteLine();
                }

            }

        }
    }
}
