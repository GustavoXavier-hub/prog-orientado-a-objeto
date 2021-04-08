using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class NomesEApelidos
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o seu nome próprio "); 
                string Nome = Console.ReadLine(); 
                Console.Write("Digite o seu apelido ");
                string Apelido = Console.ReadLine(); 
                Console.WriteLine("{0}, {1}", Apelido, Nome);
            }

        }
    }
}
