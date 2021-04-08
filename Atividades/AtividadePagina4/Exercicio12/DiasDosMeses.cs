using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class DiasDosMeses
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Três primeiras letras do mês? ");
                string Mes = Console.ReadLine().ToUpper();
                int Dias;
                switch (Mes)
                {
                 case "FEV":
                 Dias = 28;
                 break;
                 case "ABR":
                 case "JUN": 
                 case "SET": 
                 case "NOV":
                 Dias = 30; 
                 break;
                 default:
                 Dias = 31;
                 break;
                }
                Console.WriteLine("{0} tem {1} dias", Mes, Dias);
            }

            

        }
    }
}
