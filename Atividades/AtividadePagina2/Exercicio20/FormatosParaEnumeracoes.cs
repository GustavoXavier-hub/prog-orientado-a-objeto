using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class FormatosParaEnumeracoes
    {
        enum Situacao { Aprovado = 1, Oral, Reprovado };

        static void Main(string[] args)
        {
            {
                string Enumeracao = String.Format(
                "Geral".PadRight(15) + "{0:G}\n" +
                "Número".PadRight(15) + "{0:D}\n",
                Situacao.Oral);
                Console.WriteLine(Enumeracao);
            }

        }
    }

}
