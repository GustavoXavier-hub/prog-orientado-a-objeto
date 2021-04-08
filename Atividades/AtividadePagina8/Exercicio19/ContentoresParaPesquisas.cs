using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Pesquisas
    {
        public static int PesquisaLinear(int[] A, int X)
        {
            int I = 0;
            A[A.Length - 1] = X;
            while (A[I] != X)
                I++;
            return I;
        }
        public static int PesquisaBinaria(int[] A, int X)
        {
            int I = 0;
            A[A.Length - 1] = X;
            while (A[I] != X)
                I++;
            return I;
        }
    }
    class ContentoresParaPesquisas
    {
        static void Main(string[] args)
        {
            {
                int X, N = 10, I;
                int[] A = new int[N + 1]; 
                for (I = 0; I <= N - 1; I++) 
                A[I] = 200 + 100 * I;
                Console.Write("Digite o valor a procurar "); 
                X = Convert.ToInt16(Console.ReadLine());
                Console.Write("Pesquisa Binária (Sim/...?");
                String Perg = Console.ReadLine().ToUpper(); 
                if (Perg != "SIM")
                    I = Pesquisas.PesquisaLinear(A, X);
                    else 
                    I = Pesquisas.PesquisaBinaria(A, X);
                    if (I < N)

                    Console.WriteLine("{0} é o elemento índice {1} do vector", X, I);
                    else
                   Console.WriteLine("{0} não existe no vector!!", X);
            }
        }
    }
}
