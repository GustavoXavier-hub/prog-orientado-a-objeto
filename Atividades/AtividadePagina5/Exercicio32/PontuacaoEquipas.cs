using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio32
{
    class PontuacaoEquipas
    {
        static void Main(string[] args)
        {

            {
                String Equipa, Resultado;
                int Jogo; 
                double Pontuacao; 
                Console.Write("Nome da equipa ou ZZZ? "); 
                Equipa = Console.ReadLine().ToUpper(); 
                while (Equipa.CompareTo("ZZZ") != 0)
                {
                    Jogo = 0;
                    Pontuacao = 0;
                    Console.Write("Resultado do jogo {0}? ", Jogo + 1); 
                    Resultado = Console.ReadLine().ToUpper();
                    while (Resultado.CompareTo("F") != 0)
                    {
                        Jogo++;
                        if (Resultado == "V")
                            Pontuacao += 3;
                        else if (Resultado == "E")
                            Pontuacao += 1;
                        Console.Write("Resultado do jogo {0}? ", Jogo + 1);
                        Resultado = Console.ReadLine().ToUpper();
                    }
                    Console.WriteLine(Equipa + " --- " + Math.Round(Pontuacao / Jogo, 2) + " pontos");
                    Console.Write("Nome da equipa ou ZZZ? ");
                    Equipa = Console.ReadLine().ToUpper();
                }


            }
        }
    }
}
