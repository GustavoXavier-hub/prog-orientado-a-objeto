using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class DatasCronologicas
    {
        static void Main(string[] args)
        {
            {
                DateTime hoje = DateTime.Now;
                string datas = String.Format(

                "Short date".PadRight(26) + "{0:d}\n" +
                "Long date".PadRight(26) + "{0:D}\n" +
                "Short time".PadRight(26) + "{0:t}\n" +
                "Long time".PadRight(26) + "{0:T}\n" +
                "Full date/short time".PadRight(26) + "{0:f}\n" +
                "Full date/long time".PadRight(26) + "{0:F}\n" +
                "General date/short time".PadRight(26) + "{0:g}\n" +
                "General date/long time".PadRight(26) + "{0:G}\n" +
                "(default)".PadRight(26) + "{0}(default = 'G')\n" +
                "Month".PadRight(26) + "{0:M}\n" +
                "RFC1123".PadRight(26) + "{0:R}\n" +
                "Sortable".PadRight(26) + "{0:s}\n" +
                "Universal sortable".PadRight(26) + "{0:u} (invariant)\n" +
                "Universal full date/time".PadRight(26) + "{0:U}\n" +
                "Year".PadRight(26) + "{0:Y}\n", hoje);
                Console.WriteLine(datas);
            }
        }
    }
}
