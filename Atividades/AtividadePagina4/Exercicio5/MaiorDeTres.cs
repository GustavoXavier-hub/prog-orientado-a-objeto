using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class MaiorDeTres
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o primeiro número ");
                double A = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Digite o segundo número ");
                double B = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Digite o terceiro número "); 
                double C = Convert.ToDouble(Console.ReadLine()); 
                double Maior;
                if (A > B)
                if (A > C)
                Maior = A;
                else Maior = C;
                else
                if (B > C)
                Maior = B;
                else
                Maior = C;
                Console.WriteLine("{0} é o maior de {1}, {2}, {3}", Maior, A, B, C);
            }

        }
    }
}
