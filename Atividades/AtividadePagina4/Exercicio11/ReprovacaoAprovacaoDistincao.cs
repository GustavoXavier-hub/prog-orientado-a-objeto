using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class ReprovacaoAprovacaoDistincao
    {
        static void Main(string[] args)
        {
            {
              const int Limaprov = 10, Limdist = 16;
              Console.Write("Nome do aluno? ");
              string Nome = Console.ReadLine();
              Console.Write("Nota Programação? ");
              int T1 = Convert.ToInt16(Console.ReadLine());
              Console.Write("Nota Matemática? ");
              int T2 = Convert.ToInt16(Console.ReadLine()); 
              Console.Write("Sistemas de Informação? ");
              int T3 = Convert.ToInt16(Console.ReadLine()); 
              string Situacao = "Reprovado";
              if (T1 >= Limaprov && T2 >= Limaprov && T3 >= Limaprov) Situacao = "Aprovado";
                if ((T1 >= Limdist && T2 >= Limdist && T3 >= Limaprov) ||
                (T1 >= Limdist && T3 >= Limdist && T2 >= Limaprov) ||
                (T2 >= Limdist && T3 >= Limdist && T1 >= Limaprov))
                Situacao = "Aprovado com distincao";
                Console.WriteLine(" {0} --- {1} ", Nome, Situacao);
            }

        }
    }
}
