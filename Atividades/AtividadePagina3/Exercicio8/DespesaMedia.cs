using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class DespesaMedia
    {
        static void Main(string[] args)
        {
            {
                const double Aumento = 20; 
                Console.Write("Digite a despesa do primeiro ->");
                double D1 = Convert.ToDouble(Console.ReadLine()); 
                double D2 = D1 * (1 + Aumento / 100); double D3 = D2 * (1 + Aumento / 100); 
                double D4 = D3 * (1 + Aumento / 100); double Dmedia = (D1 + D2 + D3 + D4) / 4; 
                Console.WriteLine("Despesa média diária {0:F2} euros", Dmedia);
            }

        }
    }
}
