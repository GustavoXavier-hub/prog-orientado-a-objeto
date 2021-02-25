using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_faculdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "gustavo xavier";

            string nome2 = "diego";

            int idade = 19;

            /* inicio
          string frase = nome1 + "o nome e" + nome2;


        //string frase1 = nome1 + "tem a idade de" + idade.ToString();

        fim*/

            int i = 0;
             while(i++ < 5) 
            {
                if (i % 2 == 0)
                 Console.WriteLine(nome1);
                 else 
                 Console.WriteLine("if nao foi feito");
                
            }

        }
    }

}