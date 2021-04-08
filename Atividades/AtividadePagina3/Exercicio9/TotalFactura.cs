using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class TotalFactura
    {
        static void Main(string[] args)
        {
            {
                const double Aumento = 20; Console.Write("Valor dos produtos ->");
                double Vprodutos = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Percentagem de desconto %->");
                double Perdesc = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Taxa de IVA %->");
                double Taxaiva = Convert.ToDouble(Console.ReadLine()); 
                double Desc = Vprodutos * Perdesc / 100;
                double Total = Vprodutos - Desc; 
                double Iva = Total * Taxaiva / 100;
                Total += Iva; 
                Console.WriteLine("Total a pagar={0:F2} euros", Total);
            }
        }
    }
}
