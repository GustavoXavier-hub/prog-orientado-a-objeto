using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class ErrosDeConversao
    {
        public  static void Main(string[] args)
        {
            {
                double Desv = 0; 
                double[] D = { 5.78, 7, 6.54, 3.345, 10, 10.9 };
                int[] I = new int[D.Length];
                for (int J = 0; J < D.Length; J++)
                {
                    try
                    {
                        I[J] = (int)D[J]; 
                        if (I[J] != D[J]) 
                        throw new Exception();
                    }
                    catch 
                    {

                        Console.WriteLine("{0} foi truncado para {1}", D[J], I[J]); 
                        Desv += D[J] - I[J];
                    }
                }
                Console.WriteLine("\n Somatório dos erros {0}", Desv);
            }
        }
    }
}
