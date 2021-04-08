using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Somatorio
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
                double Total = 0;
                for (int I = 0; I <= N - 1; I++)
                    Total += A[I];
                Console.WriteLine("Somatório dos elementos={0,4:F2}", Total);
            }
        }
    }
}
