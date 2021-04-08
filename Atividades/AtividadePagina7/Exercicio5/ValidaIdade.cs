using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class ValidaIdade
    {
        static void Main(string[] args)
        {
            {
                int X = 0;
                bool Valida = false;
                while (Valida == false)
                    try
                    {
                        Console.Write("Digite a sua idade >"); 
                        X = Convert.ToInt16(Console.ReadLine());
                        Valida = X >= 17 && X <= 77; 
                        if (Valida == false)
                        throw new Exception();
                    }
                    catch 
                    {
                        Console.WriteLine ("A idade é um número inteiro igual superior a 17 e inferior ou igual a 77");
                     }
                Console.WriteLine("Idade validada: {0} anos", X);
            }
            

        }
    }
}
