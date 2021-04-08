using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class ConversaoDeGraus
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite a temperatura em graus Fahrenheit -> ");
                double F = Convert.ToDouble(Console.ReadLine()); 
                double C = (F - 32) / 1.8;
                Console.WriteLine("{0:F1} graus Fahrenheit={1:F1} graus" + " Celsius", F, C);
            }

        }
    }
}
