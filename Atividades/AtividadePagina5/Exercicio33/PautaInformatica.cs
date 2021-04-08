using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio33
{
    class PautaInformatica
    {
        static void Main(string[] args)
        {
            {
                string Pauta = "Nome".PadRight(20) + "Class. final" + "\n"; 
                int Maisalta = 0, Nota, Notafinal, Peso, Pesos; char Tipo;
                string Nome, Disc; 
                Console.Write("Quantos alunos sao "); 
                int N = Convert.ToInt16(Console.ReadLine());
                for (int A = 1; A <= N; A++)
                {
                    Console.Write("Nome "); 
                    Nome = Console.ReadLine(); 
                    Notafinal = 0; Pesos = 0; 
                    Console.Write("Nome da disciplina ou ZZZ "); 
                    Disc = Console.ReadLine();
                    Console.Write("Tipo de disciplina (A ou S) "); 
                    Tipo = Convert.ToChar(Console.ReadLine());
                    Console.Write("Nota "); 
                    Nota = Convert.ToInt16(Console.ReadLine());
                    while (Disc.ToUpper() != "ZZZ")
                    {
                        Peso = 1;
                        if (Tipo == 'A' || Tipo == 'a')
                          Peso = 2; 
                        Pesos += Peso; 
                        Notafinal += Peso * Nota;
                        Console.Write("Nome da disciplina ou ZZZ ");
                        Disc = Console.ReadLine();
                        Console.Write("Tipo de disciplina (A ou S) "); 
                        Tipo = Convert.ToChar(Console.ReadLine());
                        Console.Write("Nota "); 
                        Nota = Convert.ToInt16(Console.ReadLine());
                    }
                    Notafinal = Notafinal / Pesos;
                    if (Notafinal >= Maisalta)
                        Maisalta = Notafinal;
                    Pauta += Nome.PadRight(25) + Notafinal + "\n";
                }
                Pauta += "\n\nNota mais alta: " + Maisalta; 
                Console.Clear();
                Console.WriteLine(Pauta);
            }
        }
    }
}
