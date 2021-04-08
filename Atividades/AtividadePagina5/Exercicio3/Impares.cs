using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Impares
    {
        static void Main(string[] args)
        {
            {
                int A, B;
                do
                {
                    Console.Write("Limite inferior");
                    A = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Limite superior ");
                    B = Convert.ToInt16(Console.ReadLine());
                } while (A > B);
                if (A % 2 == 0)
                    A++;
                for (int Impar = A; Impar <= B; Impar += 2)
                    Console.WriteLine(Impar);
            }

        }
    }
}
