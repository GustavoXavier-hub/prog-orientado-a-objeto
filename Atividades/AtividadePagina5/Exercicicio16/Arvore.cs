using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicicio16
{
    class Arvore
    {
        static void Main(string[] args)
        {
            {
                const char C = '*'; 
                const char Espaco = ' '; 
                Console.Write("Número de linhas da árvore "); 
                int A = Convert.ToInt16(Console.ReadLine()); 
                int Impar = 1; int Inicio = (int)((A * 2 - 1));
                for (int L = 1; L <= A; L++)
                {
                    for (int Esp = 1; Esp <= Inicio; Esp++) 
                    Console.Write(Espaco);
                    for (int Caract = 1; Caract <= Impar; Caract++)
                    Console.Write(C); 
                    Console.WriteLine(); 
                    Impar += 2;
                    Inicio--;
                }
            }
        }
    }
}
