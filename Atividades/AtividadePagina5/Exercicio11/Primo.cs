using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Primo
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite um numero inteiro "); 
                int n = Convert.ToInt32(Console.ReadLine());
                bool primo = true; int div = 2;
                while ((primo == true) && (div <= (int)Math.Sqrt(n)))
                {
                    if (n % div == 0)
                        primo = false;
                    else
                        div++;
                }
                if (primo == true)
                    Console.WriteLine(n + " e primo");
                   else
                    Console.WriteLine(n + " não é primo");
            }

        }
    }
}
