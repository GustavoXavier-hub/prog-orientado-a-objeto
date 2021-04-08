using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class OrdenacaoaAlfabetica
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Quantos nomes tem a lista? ");
                int K = Convert.ToInt16(Console.ReadLine());
                string[] Nomes = new string[K]; 
                string Temporaria; 
                int N = K - 1, Indicemenor;
                for (int I = 0; I <= N; I++)
                {
                    Console.Write("{0} nome? ", I + 1); 
                    Nomes[I] = Console.ReadLine();
                }
                for (int Pas = 0; Pas <= N - 1; Pas++)
                {
                    Indicemenor = Pas;
                    for (int I = Pas + 1; I <= N; I++)
                    if (Nomes[Indicemenor].CompareTo(Nomes[I]) >= 0)
                      Indicemenor = I;
                    if (Indicemenor != Pas)
                    {
                        Temporaria = Nomes[Pas]; 
                        Nomes[Pas] = Nomes[Indicemenor]; 
                        Nomes[Indicemenor] = Temporaria;
                    }
                    Console.WriteLine("\nLista ordenada:"); 
                    for (int I = 0; I <= N; I++)
                   Console.WriteLine(Nomes[I]);
                }
            }
        }
    }
}
