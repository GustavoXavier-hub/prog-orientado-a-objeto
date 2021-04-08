using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class TracaDeValores
    {
        static void Main(string[] args)
        {
            {
                string X, Y; Console.Write("Digite o valor da primeira variavel (X) ");
                X = Console.ReadLine(); Console.Write("Digite o valor da segunda variavel (Y) ");
                Y = Console.ReadLine(); 
                Troca(ref X, ref Y); Console.WriteLine("X= {0}", X); 
                Console.WriteLine("Y= {0}", Y);
            }
        }
        static void Troca(ref string X, ref string Y)
        {
            {
                string Temporaria; 
                Temporaria = X; X = Y; Y = Temporaria;
            }
        }
    }
}
