using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class SeleccaoNomes
    {
        static void Main(string[] args)
        {
            {
                string[] Nomes = { "Ana", "António", "Beatriz", "Joana", "Raul", "Vitoria" };
                int X = 4; EscreverLista(Nomes, X);
                Console.WriteLine("Seleccionámos {0} de {1} nomes", X, Nomes.Length);
            }
        }
        static void EscreverLista(string[] Nomes, int Conta)
        {
            for (int I = 0; I < Conta; I++)
            {
                Console.WriteLine(Nomes[I]);
            }
        }
    }
}
