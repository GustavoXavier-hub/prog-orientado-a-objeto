using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class ContarPalavras
    {
        static void Main(string[] args)
        {

            {
                string Frase = "Hoje, joga o FCP com a Naval."; 
                int Contapal = 0;
                for (int X = 1; X < Frase.Length; X++)
                {
                    if (Frase.Substring(X, 1) == " " ||
                        Frase.Substring(X, 1) == ".")
                        Contapal++;
                }
                Console.Clear();
                Console.WriteLine("A frase: {0,30} tem {1,2} palavras.", Frase, Contapal);
            }
        }
    }
}
