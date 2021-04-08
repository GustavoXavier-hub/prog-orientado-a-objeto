using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio35
{
    class R35
    {
        static void Main(string[] args)
        {
            {
                char Esq, Dirta; Console.Write("Digite uma palavra ");
                String Palavra = Console.ReadLine().ToUpper(); 
                int Numcaract = Palavra.Length;
                bool Palindromo = true;
                for (int C = 0; (C < Numcaract / 2 && Palindromo == true); C++)
                {
                    Esq = Convert.ToChar(Palavra.Substring(C, 1));
                    Dirta = Convert.ToChar(Palavra.Substring(Numcaract - 1 - C, 1));
                    if (Esq != Dirta)
                   Palindromo = false;
                }
                Console.WriteLine("{0} {1}", Palavra, Palindromo == true ? " é palíndromo" : "não é palíndromo"); 
            }
        }
    }
}
