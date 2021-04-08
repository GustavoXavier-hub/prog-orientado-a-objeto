using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Cambios
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite a quantia em dólares americanos "); 
                double Usd = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a taxa de câmbio: número de euros" + " por um dólar americano ");
                double Taxa = Convert.ToDouble(Console.ReadLine()); 
                double Eur = Usd * Taxa;
                Console.WriteLine("{0} dólares americanos equivalem a {1}" + " euros", Usd, Eur);
            }

        }
    }
}
