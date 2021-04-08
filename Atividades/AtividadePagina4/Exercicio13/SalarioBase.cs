using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class SalarioBase
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite a categoria profissional> ");
                char Categ = Convert.ToChar(Console.ReadLine().ToUpper());
                double Salbase;
                switch (Categ)
                {
                 case 'A': 
                 case 'B': 
                 case 'C':
                 Salbase = 1500;
                 break;
                 case 'D':
                 Salbase = 1250;
                 break;
                 case 'E':
                 case 'F':
                 Salbase = 1000;
                 break;
                 default:
                 Salbase = 500;
                 break;
                }
                Console.WriteLine("A categoria {0} tem {1} euros de salário base", Categ, Salbase);

            }

        }
    }
}
