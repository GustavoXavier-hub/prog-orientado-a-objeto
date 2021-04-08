using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio27
{
    class MaiorEMenor
    {
        static void Main(string[] args)
        {

            {
                double Maxi = 0; 
                double Mini = Math.Pow(10, 10);
                String Lista = "";
                Console.Write("Digite o primeiro numero %(-1 para terminar) ");
                double Numero = Convert.ToDouble(Console.ReadLine());
                while (Numero != -1)
                {
                    Lista += Convert.ToString(Numero) + " ";
                    if (Numero >= Maxi)
                        Maxi = Numero;
                        else
                        if (Numero <= Mini)
                        Mini = Numero;
                    Console.Write("Digite o próximo número %(-1 para terminar) "); 
                    Numero = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("{0} \n Maior={1} \n Menor={2}", Lista, Maxi, Mini);
            }
        }
    }
}
