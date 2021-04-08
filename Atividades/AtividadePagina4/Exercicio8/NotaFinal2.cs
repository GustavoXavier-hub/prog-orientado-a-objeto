using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class NotaFinal2
    {
        static void Main(string[] args)
        {
            {
                const int Limaprov = 10; 
                const double Peso1 = 0.2; 
                const double Peso2 = 0.5; 
                const double Peso3 = 0.3;
                string Situacao;
                Console.Write("Nome do aluno? "); 
                string Nome = Console.ReadLine();
                Console.Write("Nota teste 1? "); 
                double T1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota teste 2? "); 
                double T2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota teste 3? ");
                double T3 = Convert.ToDouble(Console.ReadLine());
                int Clfinal = (int)(Peso1 * T1 + Peso2 * T2 + Peso3 * T3 + 0.5); 
                if (Clfinal >= Limaprov) 
                Situacao = "Aprovado";
                else
                Situacao = "Reprovado";
                Console.WriteLine(" {0} --- {1} --- {2}", Nome, Clfinal, Situacao);
            }

        }
    }
}
