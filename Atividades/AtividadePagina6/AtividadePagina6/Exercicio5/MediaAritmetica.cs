using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class MediaAritmetica
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos elementos tem o vector? "); 
                int N = Convert.ToInt16(Console.ReadLine());
                double[] A = new double[N]; 
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.Write("Elemento {0}=", I + 1); 
                    A[I] = Convert.ToDouble(Console.ReadLine());
                }
                double Med = 0; 
                for (int I = 0; I <= N - 1; I++) 
                 Med += A[I]; 
                Med = Med / N;
                Console.WriteLine("Média aritmética={0,4:F2}", Med);
            }

        }
    }
}
