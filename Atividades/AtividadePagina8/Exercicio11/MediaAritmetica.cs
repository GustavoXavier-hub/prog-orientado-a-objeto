using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class MediaAritmetica
    {
        static void LeituraVector(double[] A)
        {
            {
                for (int I = 0; I <= A.Length - 1; I++)
                {
                    Console.Write("Elemento {0}=", I + 1);
                    A[I] = Convert.ToDouble(Console.ReadLine());
                }
            }

        }
        static double Media(double[] A)
        {
            double Soma = 0; 
            for (int I = 0; I <= A.Length - 1; I++)
                Soma += A[I];
            return Soma / (A.Length);
        }

        static void Main(string[] args)
        {
            {
                Console.Write("Quantos elementos tem o vector? ");
                int N = Convert.ToInt16(Console.ReadLine());
                double[] A = new double[N]; LeituraVector(A);
                Console.WriteLine("Média aritmética={0,4:F2}", Media(A));
            }
        }
    }
}
