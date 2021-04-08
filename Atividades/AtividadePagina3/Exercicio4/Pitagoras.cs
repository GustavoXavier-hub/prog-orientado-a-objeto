using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Pitagoras
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Medida de um cateto? ");
                double C1 = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Medida do outro cateto? "); 
                double C2 = Convert.ToDouble(Console.ReadLine()); 
                double H = Math.Sqrt(Math.Pow(C1, 2) + Math.Pow(C2, 2));
                Console.WriteLine("Hipotenusa={0}", H);
            }

        }
    }
}
