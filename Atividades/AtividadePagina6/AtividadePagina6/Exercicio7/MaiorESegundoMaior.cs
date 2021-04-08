using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class MaiorESegundoMaior
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
                int Indmax1 = 0, Indmax2 = 0; 
                for (int I = 1; I <= N - 1; I++)
                {
                    if (A[I] >= A[Indmax1])
                    {
                        Indmax2 = Indmax1; 
                        Indmax1 = I;
                    }
                    else
                     if (A[I] >= A[Indmax2])
                        Indmax2 = I;
                }
                Console.WriteLine("O maior elemento {0} tem o índice {1}", A[Indmax1], Indmax1); 
                Console.WriteLine("O segundo maior elemento {0} tem o índice" + " {1} ", A[Indmax2], Indmax2);
            }
        }
    }
}
