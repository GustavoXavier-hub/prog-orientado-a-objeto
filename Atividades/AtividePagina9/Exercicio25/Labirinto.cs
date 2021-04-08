using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class Labirinto
    {
        static void Saidas(char[,] L, int Linha, int Coluna)
        {
            {
                const char Saida = 'S'; 
                const char Sim = ' ';
                L[Linha, Coluna] = Saida; 
                Boolean Fim = Bordo(Linha, Coluna, L.GetLength(0));
                if (Fim == true)
                ImprimirLabirinto(L);
                else
                {
                    if (L[Linha - 1, Coluna] == Sim)
                    {
                        Saidas(L, Linha - 1, Coluna);
                    }
                    if (L[Linha, Coluna + 1] == Sim) 
                        Saidas(L, Linha, Coluna + 1);
                    if (L[Linha, Coluna + 1] == Sim) 
                        Saidas(L, Linha, Coluna + 1);
                    if (L[Linha, Coluna - 1] == Sim) 
                        Saidas(L, Linha, Coluna - 1);
                }
            }
        }
        static Boolean Bordo(int Linha, int Coluna, int N)
        {
            return (Linha == N - 1) || (Coluna == N - 1) || (Linha == 0) || (Coluna == 0);
        }

        static void ImprimirLabirinto(char[,] L)
        {
            String Ts = ""; 
            for (int I = 0; I <= L.GetLength(0) - 1; I++)
                for (int J = 0; J <= L.GetLength(0) - 1; J++)
                {
                    Ts += L[I, J]; Ts += "\n";
                }
            Console.WriteLine("Saída do labirinto\n\n" + Ts);
        }

        static void Main(string[] args)
        {
            const char Nao = '*'; 
            const char Sim = ' ';
            int N = 10; char[,] L = new char[N, N];
            for (int I = 0; I <= N - 1; I++) 
            for (int J = 0; J <= N - 1; J++)
            L[I, J] = Nao;
            L[0, 3] = Sim;
            L[1, 3] = Sim; L[1, 4] = Sim;
            L[1, 5] = Sim; L[1, 6] = Sim;
            L[2, 3] = Sim; L[2, 6] = Sim;
            L[2, 7] = Sim; L[3, 3] = Sim; 
            L[3, 4] = Sim; L[3, 5] = Sim;
            L[3, 7] = Sim; L[3, 8] = Sim; 
            L[4, 4] = 'P'; L[4, 5] = Sim; 
            L[4, 8] = Sim; L[5, 5] = Sim; 
            L[5, 8] = Sim; L[6, 5] = Sim; 
            L[7, 5] = Sim; L[7, 6] = Sim; 
            L[7, 7] = Sim; L[8, 4] = Sim; 
            L[8, 5] = Sim; L[8, 7] = Sim; 
            L[9, 4] = Sim; L[9, 7] = Sim; 
            Console.Clear(); Saidas(L, 4, 4);
        }
    }
}
