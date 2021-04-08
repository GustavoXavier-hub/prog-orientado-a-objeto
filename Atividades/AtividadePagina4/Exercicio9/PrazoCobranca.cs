using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class PrazoCobranca
    {
        static void Main(string[] args)
        {
            const int Limaximo = 270, Limedio = 180;
            string Interpreta;
            Console.Write("Total de vendas? "); 
            double Totvendas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Percentagem de pagamento a pronto? ");
            double Percpronto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dívidas de clientes? ");
            double Clidiv = Convert.ToDouble(Console.ReadLine());
            Console.Write("Letras a receber em carteira? "); 
            double Letcart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Letras a receber descontadas? ");
            double Letdesc = Convert.ToDouble(Console.ReadLine()); 
            double Vcredito = Totvendas * (1 - Percpronto / 100);
            double Total = Clidiv + Letcart + Letdesc; double Prazomedio = Total * 365 / Vcredito;
            if (Prazomedio >= Limaximo)
               Interpreta = "EXCESSIVO";
            else if (Prazomedio >= Limedio) 
               Interpreta = "SATISFATORIO";
            else Interpreta = "FAVORAVEL";
            Console.WriteLine(" {0} dias --- {1} ", Prazomedio, Interpreta);
        }
    }
}
