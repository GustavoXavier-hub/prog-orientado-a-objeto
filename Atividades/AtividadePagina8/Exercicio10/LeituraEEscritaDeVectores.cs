using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class LeituraEEscritaDeVectores
    {
        static void LeituraVector(string[] A)
        {
            {
                for (int I = 0; I <= A.Length - 1; I++)
                {
                    Console.Write("Cidade {0}=", I + 1);
                    A[I] = Console.ReadLine();
                }
            }
        }
        static void EscritaVector(string[] A)
        {
            foreach (string I in A)
            Console.Write(I + "\n");
        }
        static void Main(string[] args)
        {
            {
                Console.Write("Quantas cidades há? "); 
                int N = Convert.ToInt16(Console.ReadLine()); 
                string[] A = new string[N]; 
                LeituraVector(A);
                EscritaVector(A);
            }
        }
    }
}
