using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class NotaFinal
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o nome do aluno ->"); 
                string Nome = Console.ReadLine();
                Console.Write("Digite a nota do teste 1 ->"); 
                double T1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a nota do teste 2 ->"); 
                double T2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a nota do teste 3 ->");
                double T3 = Convert.ToDouble(Console.ReadLine()); 
                double Final = (T1 + T2 + T3) / 3;
                Console.WriteLine("{0} obteve {1} valores", Nome, Math.Round(Final, 0));
            }

        }
    }
}
