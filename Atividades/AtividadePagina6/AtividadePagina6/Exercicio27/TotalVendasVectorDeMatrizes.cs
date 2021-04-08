using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio27
{
    class TotalVendasVectorDeMatrizes
    {
        static void Main(string[] args)
        {
            {
                int N = 3; 
                double[][,] Prod = new double[N][,];
                Prod[0] = new double[,] { { 1, 1000, 10 }, { 12, 500, 15 } };
                Prod[1] = new double[,] { { 1, 200 }, { 2, 300 }, { 3, 400 }, { 4, 500 } };
                Prod[2] = new double[,] { { 10, 1000, 5 }, { 11, 2000, 10 }, { 12, 3000, 15 } };
                double Totvendas = 0, Tot = 0;
                for (int P = 0; P <= N - 1; P++)
                {
                    Tot = 0; Console.Write("Subtotal produto {0}=", P + 1);
                    for (int I = 0; I <= Prod[P].GetLength(0) - 1; I++)
                    {
                        Tot += Prod[P][I, 1]; 
                        for (int J = 2; J <= Prod[P].GetLength(1) - 1; J++) 
                        Tot -= Prod[P][I, J];
                    }
                    Console.WriteLine(Tot); 
                    Totvendas += Tot;
                }
                Console.WriteLine("Total das vendas={0} ", Totvendas);
            }
        }
    }
}
