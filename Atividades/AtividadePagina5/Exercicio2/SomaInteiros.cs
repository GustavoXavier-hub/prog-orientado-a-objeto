using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class SomaInteiros
    {
        static void Main(string[] args)
        {
            {
            Console.Write("Limite superior do intervalo de inteiros? ");
            int N = Convert.ToInt32(Console.ReadLine());
            int Soma = 0; 
            for (int I = 1; I <= N; I++) 
            Soma += I;
            Console.WriteLine("Total da adição dos {0} inteiros={1}", N, Soma);
            }

        }
    }
}
