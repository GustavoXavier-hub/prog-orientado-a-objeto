using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class RelatorioVendas
    {
        static void Main(string[] args)
        {
            {
                const int Mesano = 12; 
                double[] Vendas = new double[12]; 
                for (int M = 0; M < Mesano; M++)
                Vendas[M] = 0; Console.Write("Mês da venda ou 0 para terminar "); 
                int Mes = Convert.ToInt16(Console.ReadLine());
                Console.Write("Valor da venda ");
                double Vvendas = Convert.ToDouble(Console.ReadLine()); 
                while (Mes != 0)
                {
                    Vendas[Mes - 1] += Vvendas; 
                    Console.Write("Mês da venda ou 0 para terminar "); 
                    Mes = Convert.ToInt16(Console.ReadLine()); 
                    Console.Write("Valor da venda "); 
                    Vvendas = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("{0,5} {1, 15}", "Mês", "Total de Vendas");
                for (int M = 0; M < Mesano; M++)
                    if (Vendas[M] != 0)
                 Console.WriteLine("{0,4}{1, 10}", M + 1, Vendas[M]);
            }
        }
    }
}
