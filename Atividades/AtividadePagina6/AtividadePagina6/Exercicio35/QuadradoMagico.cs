using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio35
{
    class QuadradoMagico
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Introduza a dimensão do quadrado: ");
                int N = Convert.ToInt16(Console.ReadLine()); 
                if (N % 2 == 0) N++; int[,] Quad = new int[N, N];
                int Colcorr = (0 + N - 1) / 2, Colprox = 0; 
                int Lincorr = 0, Linprox = 0; int Z = 1;
                Quad[Lincorr, Colcorr] = Z;
                for (Z = 2; Z <= N * N; Z++)
                {
                    Linprox = Lincorr - 1; 
                    if (Linprox < 0) 
                    Linprox = N - 1; 
                    Colprox = Colcorr - 1;
                    if (Colprox < 0) 
                    Colprox = N - 1;
                    if (Quad[Linprox, Colprox] != 0)
                    Linprox++; 
                    Lincorr = Linprox;
                    Colcorr = Colprox;
                    Linprox++; Lincorr = Linprox; Colcorr = Colprox;
                }
                int Total = 0;
                for (Lincorr = 0; Lincorr <= N - 1; Lincorr++)
                {
                    for (Colcorr = 0; Colcorr <= N - 1; Colcorr++)
                    {
                        if (Lincorr == Colcorr)
                            Total += Quad[Lincorr, Colcorr]; 
                        Console.Write("{0,4}", Quad[Lincorr, Colcorr]);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("Total das linhas, colunas e " + "diagonais={0}", Total);
            }
        }
    }
}
