using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class VariacaoDePrecos
    {
        static void Main(string[] args)
        {
            {
                const int Pmaxima = 5;
                Console.Write("Preço actual? "); 
                double Pactual = Convert.ToDouble(Console.ReadLine());
                Console.Write("Preço anterior? "); 
                double Pantes = Convert.ToDouble(Console.ReadLine());
                double Varia = (Pactual - Pantes) / Pantes * 100; string Aviso = "";
                if (Varia > Pmaxima)
                    Aviso = "Aumento excessivo!";
                Console.WriteLine(" {0,3:F2}% ---> {1}", Varia, Aviso);
            }

        }
    }
}
