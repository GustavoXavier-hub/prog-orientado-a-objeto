using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class BomDiaBoaTarde
    {
        static void Main(string[] args)
        {
            {
                const int Meiodia = 12;
                int Horacorrente = DateTime.Now.Hour;
                string Msg = "";
                if (Horacorrente < Meiodia)
                 Msg = "Bom dia";
                else
                 Msg = "Boa Tarde";
                Console.WriteLine(Msg);
            }

        }
    }
}
