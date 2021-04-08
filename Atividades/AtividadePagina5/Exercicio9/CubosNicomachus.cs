using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class CubosNicomachus
    {
        static void Main(string[] args)
        {
            {
                int N, Impar, Cubo;
                Console.Write("Limite superior do intervalo de inteiros ");
                N = Convert.ToInt32(Console.ReadLine());
                Impar = 1; 
                string Ts;
                for (int I = 1; I <= N; I++)
                {
                    Cubo = 0; Ts = "";
                    for (int J = 1; J <= I; J++)
                    {
                        Cubo += Impar;
                        Ts += "+" + Convert.ToString(Impar);
                        Impar += 2;
                    }
                    Console.WriteLine("{0} ao cubo={1} ={2}", I, Ts, Cubo);
                }
            }
        }
    }
}
