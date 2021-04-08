using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class MaiorEMenor
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos elementos tem o vector? ");
                int N = Convert.ToInt16(Console.ReadLine()); 
                double[] A = new double[N];
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.Write("Elemento {0}=", I);
                    A[I] = Convert.ToDouble(Console.ReadLine());
                }
                int Indmax = 0, Indmin = 0; 
                for (int I = 1; I <= N - 1; I++)
                {
                    if (A[I] < A[Indmin])
                        Indmin = I;
                    else if (A[I] > A[Indmax])
                        Indmax = I;
                }
                Console.WriteLine("Maior elemento: " + A[Indmax]);
                Console.WriteLine("Menor elemento: " + A[Indmin]);
            }
        }
    }
}
