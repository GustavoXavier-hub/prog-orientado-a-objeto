using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class Palindromo
    {
        static string Tirarespacos(string Frase, int Indice)
        {
            {
                if (Indice == 0) 
               return Frase.Substring(Indice, 1);
               else
               if (Frase.Substring(Indice, 1) == " ")
               return Tirarespacos(Frase, Indice - 1);
               else
               return Frase.Substring(Indice, 1) + Tirarespacos(Frase, Indice - 1);
            }
        }

        static Boolean Palind(string Palavra, int Indice)
        {
            string Ce, Cd; 
            if (Indice > (Palavra.Length - 1) / 2)
            return true;
            else
            {
                Ce = Palavra.Substring(Indice, 1); 
                Cd = Palavra.Substring(Palavra.Length - 1 - Indice, 1);
                if (Ce != Cd) return false;
                else
               return Palind(Palavra, Indice + 1);
            }
        }

        static void Main(string[] args)
        {
            {
                string Frase = "A base do teto desaba";
                string Palavra = Tirarespacos(Frase.ToLower(), Frase.Length - 1);
                Console.Write("'" + Frase + "'");
                Console.WriteLine(Palind(Palavra, 0) ? " é um palíndromo." : " não é um palíndromo.");
            }
        }
    }
}
