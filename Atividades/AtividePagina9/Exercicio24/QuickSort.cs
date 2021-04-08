using System;

namespace Exercicio24
{
    class QuickSort
    {
        static void OrdenaRapida(int[] V, int Inicio, int Fim)
        {
            {
                int Temp;
                int Esq = Inicio;
                int Direita = Fim;
                int Inicial = V[(Inicio + Fim) / 2];
                while (Esq < Direita)
                {
                    while (V[Esq] < Inicial)
                    {
                        Esq++;
                        while (Inicial < V[Direita])
                            Direita--;
                        if (Esq <= Direita)
                        {
                          Temp = V[Esq];
                            V[Esq] = V[Direita];
                            V[Direita] = Temp;
                            Esq++; 
                            Direita--;
                        }
                    }
                    if (Inicio < Direita)
                        OrdenaRapida(V, Inicio, Direita);
                    if (Esq < Fim)
                        OrdenaRapida(V, Esq, Fim);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] V = { 10, 90, 67, 45, 78, 32, 17, 89, 100, 108, 21 };
            OrdenaRapida(V, 0, V.Length - 1);
            foreach (int I in V) Console.Write("{0,5:D2}", I);
            Console.WriteLine();
        }
    }
}
