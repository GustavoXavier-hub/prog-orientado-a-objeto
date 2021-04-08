using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class CapitalAcumulado
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o capital inicial "); 
                double X = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Digite a taxa anual de juro (%) "); 
                double I = Convert.ToDouble(Console.ReadLine());
                double Capacumulado = X * Math.Pow((1 + I / 100), 2);
                Console.WriteLine("{0} euros capitalizado durante 2 anos" +
                " à taxa anual de {1}% resultam em {2} euros", X, I, Capacumulado);
            }

        }
    }
}
