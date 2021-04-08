using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class EfeitosIndesejados
    {
        static void Triplo(int A)
        {
            {
                A = 3 * A;
            }
        }

        static void Main(string[] args)
        {
            {
                Console.Write("Digite um número ");
                int A = Convert.ToInt16(Console.ReadLine());
                Triplo(A); Console.WriteLine("Triplo do número={0}", A);
            }
        }
        class CorreccaoEfeitosIndesejadosR
        {
            static void Triplo(ref int A)
            {
                {
                    A = 3 * A;
                }
            }

        }
            



    }
}
