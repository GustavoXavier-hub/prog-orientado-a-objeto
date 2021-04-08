using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class ContagemNomes
    {
        static void ContaIniciais(string Nome, ref int Conta)
        {
            {
                if ((Nome.Substring(0, 1) == "A") || (Nome.Substring(0, 1) == "B")
                    || (Nome.Substring(0, 1) == "C"))
                    Conta++;
            }
        }
        static void Main(string[] args)
        {
            int Conta = 0; 
            string Nome; Console.Write("Digite um nome ou ZZZ "); 
            Nome = Console.ReadLine().ToUpper();
            while (Nome.ToUpper() != "ZZZ")
            {
                ContaIniciais(Nome, ref Conta);
                Console.Write("Digite um nome ou ZZZ "); 
                Nome = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Há {0} nomes começados por A, B ou C", Conta);
        }
    }
}
