using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class OrdenacaoVector
    {

        static void Ordena(string[] X)
        {
            {
                string Temp;
                for (int P = X.Length - 1; P >= 1; P--)
                    for (int Corrente = 0; Corrente <= P - 1; Corrente++)
                        if (X[Corrente].CompareTo(X[Corrente + 1]) > 0)
                        {
                            Temp = X[Corrente];
                            X[Corrente] = X[Corrente + 1];
                            X[Corrente + 1] = Temp;
                        }
            }
        }
        static void EscritaVector(string[] X)
        {
            foreach (string I in X)
                Console.Write(I + "\n");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            {
                string[] A = { "Joana", "Rui", "Adelaide", "Joaquim", "Teresa", "Miguel" };
                string[] B = { "Maria", "Gabriela", "Rita", "Martinho" };
                Ordena(A);
                EscritaVector(A);
                Ordena(B); 
                EscritaVector(B);
            }
        }
    }
}
