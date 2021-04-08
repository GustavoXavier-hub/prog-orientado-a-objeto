using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class LeituraEEscritaNElementos
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos elementos tem o vector? "); 
                int N = Convert.ToInt16(Console.ReadLine());
                int[] A = new int[N];
                for (int I = 0; I <= N - 1; I++) 
                { Console.Write("Elemento {0}=", I + 1);
                 A[I] = Convert.ToInt16(Console.ReadLine()); 

                }
                foreach (int Elemento in A) Console.WriteLine("{0, 4}", Elemento);
            }
        }
    }
}
