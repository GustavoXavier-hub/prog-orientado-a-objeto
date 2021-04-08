using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class OperadorTernario
    {
        static void Main(string[] args)
        {
            {
               Console.Write("Nota do exame "); 
               int Nota = Convert.ToInt16(Console.ReadLine());
               Console.WriteLine(Nota > 5 ? "Parabéns" : "Marque novo exame");
            }
        }
    }
}
