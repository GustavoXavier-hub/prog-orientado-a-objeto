using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Primos
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Digite o limite inferior do intervalo "); 
                int A = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Digite o limite superior do intervalo "); 
                int B = Convert.ToInt32(Console.ReadLine()); 
                string Lista = "Primos entre " + A + " e " + B + "\n";
                if (A <= 2)
                {
                    A = 2; Lista += Convert.ToString(A);
                }
                if (A % 2 == 0)
                {
                    A += 1;
                    for (int N = A; N <= B; N += 2)
                    {
                        bool Primo = true; 
                        int Div = 2;
                        while ((Primo == true) && (Div <= (int)Math.Sqrt(N)))
                        {
                            if (N % Div == 0) 
                            Primo = false;
                            else
                            Div++;
                        }
                        if (Primo == true)
                            Lista += " " + Convert.ToString(N);
                            Console.WriteLine(Lista);
                    }

                }

            }

        }
    }
}
