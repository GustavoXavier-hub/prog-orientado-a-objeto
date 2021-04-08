using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePagina4
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
                double Maior;
                if (A > B)
                    Maior = A;
                else Maior = B;
                Console.WriteLine("{0} é o maior dos dois números:{1} e {2}", Maior, A, B);
            }

        }


    }
}