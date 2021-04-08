using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class LerLogicosEDatas
    {
        static void Main(string[] args)
        {
            {

                Console.Write("Digite a data de nascimento ");
                DateTime Datanasc = Convert.ToDateTime(Console.ReadLine());
                Console.Write("É verdade que Nuno Álvares Pereira foi " +
                "canonizado? ");
                Boolean Santo = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Data de nascimento do utilizador: {0:D} ", 
                Datanasc);
                Console.WriteLine("Respondeu {0} à questão ", Santo);
            }

        }
    }
}
