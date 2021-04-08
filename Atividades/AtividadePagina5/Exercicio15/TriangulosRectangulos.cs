using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class TriangulosRectangulos
    {
        static void Main(string[] args)
        {
            {
                const char C = '*'; 
                int A = 6; 
                int Triangulos = 5; 
                string Trian = "";
                for (int Linha = 1; Linha <= A; Linha++)
                {
                    for (int T = 1; T <= Triangulos; T++)
                    {
                        for (int Caract = 1; Caract <= Linha; Caract++)
                        {
                            Trian += C;
                            Trian += "\t";
                        }
                        Trian += "\n";
                        Console.WriteLine(Trian);
                    }
                }

            }

        }
    }
}
