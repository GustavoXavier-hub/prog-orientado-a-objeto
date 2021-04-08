using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class AdicaoEProduto
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos elementos tem cada vector? "); 
                int N = Convert.ToInt16(Console.ReadLine());
                double[] A = new double[N]; 
                double[] B = new double[N]; 
                double[] Total = new double[N];
                double[] Prod = new double[N];
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.Write("Elemento a[{0}]=", I);
                    A[I] = Convert.ToDouble(Console.ReadLine());
                }
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.Write("Elemento B[{0}]=", I);
                    B[I] = Convert.ToDouble(Console.ReadLine());
                }
                for (int I = 0; I <= N - 1; I++)
                {
                    Total[I] = A[I] + B[I];
                    Prod[I] = A[I] * B[I];
                }
                Console.WriteLine("Adição e produto dos elementos dos dois" + "vectores:");
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.WriteLine("{0,3} + {1,3}={2,4}", A[I], B[I], Total[I]); 
                    Console.WriteLine("{0,3} * {1,3}={2,4}", A[I], B[I], Prod[I]);
                }

            }
        }
    }
}
