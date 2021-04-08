using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio34
{
    class PreSeleccao
    {
        static void Main(string[] args)
        {
            {
                string Lista = "Nome".PadRight(20) + "Observação" + "\n";
                int Conta = 0, Contaselec = 0, Estagio; string Obs;
                double Perc = 0; char Ingles, Internacional;
                Console.Write("Nome do candidato ou Finalizar ");
                string Nome = Console.ReadLine();
                while (Nome.ToUpper() != "Finalizar")
                {
                    Console.Write("Nota de estagio ");
                    Estagio = Convert.ToInt16(Console.ReadLine());
                    Console.Write("FLuente em Ingles (S/...) ");
                    Ingles = Convert.ToChar(Console.ReadLine().ToUpper());
                    Console.Write("Carreira internacional (S/...) ");
                    Internacional = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (Estagio > 5 && Ingles == 'S' && Internacional == 'S')
                    {
                        Obs = "Seleccionada(o)";
                        Contaselec += 1;
                    }
                    else
                    {
                        Obs = "Eliminada(o)";
                    }
                    Lista += Nome.PadRight(15) + Obs + "\n";
                    Conta += 1;
                    Console.Write("Nome do candidato ou Finalizar ");

                    Nome = Console.ReadLine();
                    Perc = (double)Contaselec / Conta * 100;
                    Lista += "\n\n" + "% de seleccionados:" + Perc + "%";
                    Console.Clear();
                    Console.WriteLine(Lista);
                }
            
            }

        }
    }
}
