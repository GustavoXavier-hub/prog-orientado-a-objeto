using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class FormatosNumericos
    {
        static void Main(string[] args)
        {
            
                {
                    string numeros = String.Format(
                        "Decimal".PadRight(20) + "{0:D}\n" +
                        "Scientific".PadRight(20) + "{1:E}\n" +
                        "Fixed point".PadRight(20) + "{1:F}\n" +
                        "General".PadRight(20) + "{0:G}\n" +
                        "Round trip".PadRight(20) + "{1:R}\n" +
                        "Number".PadRight(20) + "{0:N}\n" +
                        "Percent".PadRight(20) + "{1:P}\n" +
                        "Hexadecimal".PadRight(20) + "{0:X}\n", 2500, 0.78876);
                         Console.WriteLine(numeros);
            }

        }
    }
}
