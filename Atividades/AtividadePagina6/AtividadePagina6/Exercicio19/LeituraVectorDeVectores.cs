using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class LeituraVectorDeVectores
    {
        static void Main(string[] args)
        {

            {
                const int N = 3; String[][] Alunos = new string[N][];
                Console.Write("Número de alunos inscritos na disciplina 1? ");
                int N1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Número de alunos inscritos na disciplina 2? ");
                int N2 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Número de alunos inscritos na disciplina 3? "); 
                int N3 = Convert.ToInt16(Console.ReadLine());
                Alunos[0] = new string[N1]; 
                Alunos[1] = new string[N2]; 
                Alunos[2] = new string[N3];
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.WriteLine("Disciplina {0}", I + 1); 
                    for (int K = 0; K <= Alunos[I].GetLength(0) - 1; K++)
                    {
                        Console.Write("Nome do {0} aluno ", K + 1); 
                        Alunos[I][K] = Console.ReadLine();
                    }
                }
                Console.WriteLine(); 
                for (int I = 0; I <= N - 1; I++)
                {
                    Console.WriteLine("Disciplina {0}", I + 1);
                    for (int K = 0; K <= Alunos[I].GetLength(0) - 1; K++) 
                    Console.WriteLine(Alunos[I][K]);
                }

            }

        }
    }
}
