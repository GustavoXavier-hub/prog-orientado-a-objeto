using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10

{
    class SalarioVendedor
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o nome do vendedor ->"); 
                string Nome = Console.ReadLine();
                Console.Write("Digite o salário base ->"); 
                double Sbase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Comissão por cada carro vendido ->"); 
                double Y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a percentagem sobre o valor das vendas" + " (%) ->");
                double P = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Número de carros vendidos ->");
                int Ncarros = Convert.ToInt16(Console.ReadLine());
                Console.Write("Digite o valor das vendas ->");
                double Vvendas = Convert.ToDouble(Console.ReadLine()); 
                double Sal = Sbase + Ncarros * Y + Vvendas * P / 100;
                Console.WriteLine("Salário a processar para {0} ->{1:F2}", Nome, Sal);
            }
            
        }
    }
}
