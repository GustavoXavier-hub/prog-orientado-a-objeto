using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Multibanco
    {
        static void Main(string[] args)
        {
            {
            Console.Clear(); 
            Console.WriteLine("1. Levantamentos");
            Console.WriteLine("2. Depósitos"); 
            Console.WriteLine("3. Pagamento de serviços"); 
            Console.WriteLine("4. Fim"); 
            Console.Write("\nDigite a sua opção -->"); 
            int Opcao = Convert.ToInt16(Console.ReadLine()); 
            double Quantia = 0;
            int Entidade = 0, Referencia = 0;
            switch (Opcao)
                {
             case 1:
            Console.WriteLine("\nLevantamentos"); 
            Console.Write("Quantia -->"); 
            Quantia = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Retire o talão");
            break;

            case 2:
            Console.WriteLine("\nDepósitos"); 
            Console.Write("Quantia -->"); 
            Quantia = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Introduza dinheiro ou cheque -->"); 
            Console.WriteLine("Retire o talão");
             break;

             case 3:
            Console.WriteLine("\nPagamento de serviços"); 
            Console.Write("Entidade -->"); 
            Entidade = Convert.ToInt16(Console.ReadLine()); 
            Console.Write("Referência -->"); 
            Referencia = Convert.ToInt16(Console.ReadLine()); 
            Console.Write("Quantia -->"); 
            Quantia = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Retire o talão");
            break;

            case 4:
            Console.WriteLine("\nFim"); 
            Console.WriteLine("Retire o cartão");

            break;


                }


            }

        }
    }
}
