using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    class OperadoresPrefixosEPosfixos

    {
        static void Main(string[] args)
        {
            
                {
                    int Valor1, Valor2;
                    int Variacao = 10; 
                    Valor1 = Variacao++;
                    Console.WriteLine("Incrementador posfixo: primeiro " + " atribui o valor e depois incrementa");
                    Console.WriteLine("Valor1={0} e Variacao={1}", Valor1, Variacao);


                    Variacao = 10; 
                    Valor1 = ++Variacao;
                    Console.WriteLine("Incrementador prefixo: primeiro " + "incrementa e depois atribui o valor");
                    Console.WriteLine("Variacao={0} e Valor1={1} ", Variacao, Valor1);

                    Variacao = 10;
                    Valor2 = Variacao--;
                    Console.WriteLine("Decrementador posfixo: primeiro" + " atribui o valor e depois decrementa"); 
                    Console.WriteLine("Valor2={0} e Variacao={1} ", Valor2, Variacao);


                    Variacao = 10; 
                    Valor2 = --Variacao;
                    Console.WriteLine("Decrementador prefixo: primeiro " + "decrementa e depois atribui o valor");
                    Console.WriteLine("Variacao={0} e Valor2={1} ", Variacao, Valor2);

            }


        }
    }
}
