using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class ErroIndice
    {
        static void Main(string[] args)
        {
            {
                int[] A = { 4, 5, 6, 2, 8, 0 };
                int N = A.Length; bool Erro = false;
                for (int I = 0; I <= N && Erro != true; I++)
                {
                    try
                    {
                        Console.WriteLine("{0,4:D}", A[I]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("O índice ultrapassou o limite máximo"); Erro = true;
                    }
                    Console.WriteLine("Mas, continuamos o processamento");
                }
            }
        }
    }
}
