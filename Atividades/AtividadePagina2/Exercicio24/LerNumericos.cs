using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    class LerNumericos
    {
        static void Main(string[] args)
        {

            {

                Console.Write("Digite a sua idade "); 
                int Idade = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Digite o seu salário ");
                double Salario = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Digite um número muito grande "); 
                decimal Grande = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Vc tem {0} anos e ganha {1} euros por mês! ", Idade, Salario);
                Console.WriteLine("Digitou o número {0}", Grande);

            }
        }
    }
}
