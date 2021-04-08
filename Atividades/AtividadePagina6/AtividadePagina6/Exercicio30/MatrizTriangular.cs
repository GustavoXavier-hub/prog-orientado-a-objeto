using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30
{
    class MatrizTriangular
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Triangular superior (S) ou inferior (I)? "); 
                Char Tipo = Convert.ToChar(Console.ReadLine());
                Console.Write("Número de linhas da matriz? ");
                int N = Convert.ToInt16(Console.ReadLine()); 
                int[,] A = new int[N, N];
                if (Tipo == 'i' || Tipo == 'I')
                {
                    for (int I = 0; I <= N - 1; I++) 
                        for (int J = 0; J <= I; J++)
                        {
                            Console.Write("a[{0},{1}] =", I, J);
                            A[I, J] = Convert.ToInt16(Console.ReadLine());
                            if (I != J)
                             A[J, I] = 0;
                        }
                }
                else
                {
                    for (int I = 0; I <= N - 1; I++) 
                     for (int J = N - 1; J >= I; J--)
                        {
                            Console.Write("a[{0},{1}]=", I, J); A[I, J] = Convert.ToInt16(Console.ReadLine());
                            if (I != J)
                             A[J, I] = 0;
                        }      
                }
                for (int I = 0; I <= N - 1; I++)
                {
                    for (int J = 0; J <= N - 1; J++) 
                    Console.Write("{0, 4}", A[I, J]); 
                    Console.WriteLine();
                }
            }
        }
    }
}
