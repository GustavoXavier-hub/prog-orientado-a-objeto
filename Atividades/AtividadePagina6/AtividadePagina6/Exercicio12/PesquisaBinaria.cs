using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class PesquisaBinaria
    {
        static void Main(string[] args)
        {
            {
                double[] A = { 100, 110, 120, 140, 160, 200, 220 }; int N = 7; 
                Console.Write("Digite o valor a procurar ");
                double X = Convert.ToDouble(Console.ReadLine()); 
                int Inf = 0, Sup = N - 1, M = 0; 
                Boolean Exito = false;
                while (Exito == false && Inf <= Sup)
                {
                    M = (Sup + Inf) / 2; 
                    if (X > A[M])
                        Inf = M + 1;
                    else if (X < A[M])
                        Sup = M - 1;
                    else
                        Exito = true;
                }
                if (Exito == true)
                    Console.WriteLine("{0} é o elemento índice {1} do vector", X, M);
                else
                    Console.WriteLine("{0} não existe no vector!!", X);
            }

        }
    }
}
