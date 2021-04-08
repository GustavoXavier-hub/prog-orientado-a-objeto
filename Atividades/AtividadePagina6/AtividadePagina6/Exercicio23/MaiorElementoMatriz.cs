using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    class MaiorElementoMatriz
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantas linhas tem a matriz? "); 
                int N = Convert.ToInt16(Console.ReadLine());
                Console.Write("Quantas colunas tem a matriz? "); 
                int M = Convert.ToInt16(Console.ReadLine());
                double[,] A = new double[N, M];
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                    {
                        Console.Write("A[{0},{1}]=", I, J);
                        A[I, J] = Convert.ToDouble(Console.ReadLine());
                    }
                int Linmax = 0; 
                int Colmax = 0;
                for (int I = 0; I <= N - 1; I++) 
                for (int J = 0; J <= M - 1; J++)
                if (A[I, J] > A[Linmax, Colmax])
                 {
                 Linmax = I;
                 Colmax = J;
                  }
                Console.WriteLine("Maior elemento:{0}", A[Linmax, Colmax]); 
                Console.WriteLine("Linha {0}", Linmax);
                Console.WriteLine("Coluna {0}", Colmax);
            }
        }
    }
}
