using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicicio20
{
    class DecomposicaoNumero
    {
        static void Main(string[] args)
        {
            {
                int Dig = 0; Console.Write("N? "); 
                int N = Convert.ToInt32(Console.ReadLine()); 
                int Nd = (int)Math.Log10(N) + 1;
                int Expoente = Nd - 1; 
                String Decomp = Convert.ToString(N) + "=";
                for (int D = 1; D <= Nd; D++)
                {
                    Dig = N / (int)Math.Pow(10, Expoente); 
                    Decomp += Convert.ToString(Dig) + "*10" + "^" + Convert.ToString(Expoente);
                    if (D != Nd)
                    Decomp += "+"; N -= Dig * (int)Math.Pow(10, Expoente);
                    Expoente--;
                }
                Console.WriteLine(Decomp);
            }
        }
    }
}
