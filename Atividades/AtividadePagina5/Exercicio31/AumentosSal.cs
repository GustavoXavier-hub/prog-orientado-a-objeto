using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio31
{
    class AumentosSal
    {
        static void Main(string[] args)
        {

            {
                int Conta = 0;
                double Mactual = 0, Mfutura = 0;
                double Perc = 0, Salfut;
                string Lista = "Nome".PadRight(35) + "Sal. Actual".PadRight(20) + "Sal. Futuro" + "\n";
                Console.Write("Digite o nome do funcionário (ZZZ pasa terminar) ");
                string Nome = Console.ReadLine(); 
                Console.Write("Digite o salário actual do funcionário ");
                double Salact = Convert.ToDouble(Console.ReadLine());
                while (Nome.ToUpper() != "ZZZ")
                {
                    Conta++;
                    if (Salact <= 500) 
                    Perc = 0.2;
                    else
                    if (Salact <= 800)
                        Perc = 0.05;
                    else
                        Perc = 0;
                    Salfut = Salact * (1 + Perc);
                    Lista += Nome.PadRight(35) + Convert.ToString(Salact).PadLeft(10) + "\t\t" + Convert.ToString(Salfut).PadLeft(10);
                    Lista += "\n";
                    Mactual += Salact;
                    Mfutura += Salfut;
                    Console.Write("Digite o nome do funcionário (ZZZ para terminar) ");
                    Nome = Console.ReadLine(); 
                    Console.Write("Digite o salário actual do funcionário ");
                    Salact = Convert.ToDouble(Console.ReadLine());
                }
                Console.Clear();
                Lista += "Massa sal. actual=" + Convert.ToString(Mactual) + "\n";
                Lista += "Massa sal. futura=" + Convert.ToString(Mfutura) + "\n";
                if (Conta == 0)
                    Lista = "Nao ha funcionarios";
                    Console.WriteLine(Lista);
            }
        }
    }
}
