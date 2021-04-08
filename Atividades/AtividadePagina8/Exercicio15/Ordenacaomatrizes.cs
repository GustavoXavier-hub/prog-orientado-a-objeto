using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Ordenacaomatrizes
    {
        static void Ordena(string[,] A, int Coluna)
        {
            for (int P = A.GetLength(0) - 1; P >= 1; P--)
            for (int Corrente = 0; Corrente <= P - 1; Corrente++) 
           if (A[Corrente, Coluna].CompareTo(A[Corrente + 1, Coluna]) > 0)
            Troca(A, Corrente);
        }
        static void Troca(string[,] A, int Corrente)
        {
            string Temp; 
            for (int J = 0; J <= A.GetLength(1) - 1; J++)
            {
                Temp = A[Corrente, J]; 
                A[Corrente, J] = A[Corrente + 1, J];
                A[Corrente + 1, J] = Temp;
            }
        }

        static void Escrita(string[,] A)
        {
            for (int I = 0; I <= A.GetLength(0) - 1; I++)
            {
                for (int J = 0; J <= A.GetLength(1) - 1; J++)
               Console.Write("{0, 10}", A[I, J].PadRight(10));
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            {
                string[,] A = { { "60", "Rui", "Porto" }, 
                    { "20", "Joaquim", "Aveiro" }, 
                    { "30", "Adelino", "Porto" },
                    { "50", "Ricardo", "Coimbra" } };
                Console.Write("Coluna (0,1,2) que é chave de ordenação ");
                int Coluna = Convert.ToInt16(Console.ReadLine());
                Ordena(A, Coluna);
                Escrita(A);
            }
        }
    }
}
