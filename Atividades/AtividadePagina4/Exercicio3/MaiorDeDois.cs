using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class MaiorDeDois
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite um número "); 
                double A = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Digite outro número "); 
                double B = Convert.ToDouble(Console.ReadLine());
                if (A > B)
                    Console.WriteLine("{0} é o maior ", A);
                else if (B > A)
                    Console.WriteLine("{0} é o maior ", B);
                else
                    Console.WriteLine("Os dois números são iguais");
            }

        }
    }
}
