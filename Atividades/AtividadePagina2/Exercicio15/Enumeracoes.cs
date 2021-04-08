using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Enumeracoes
    {
           enum notas
        {
            E = 0,
            D = 8,
            C = 10,
            B = 14,

            A = 17
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Distinção >={0} ({1})", (int)notas.A, notas.A);
                Console.WriteLine("Aprovados >={0} ({1},{2},{3})", (int)notas.C, notas.A, notas.B, notas.C);
                Console.WriteLine("Oral entre {0} e {1} ({2})", (int)notas.D, (int)notas.C, notas.D);
                Console.WriteLine("Reprovados <{0} ({1})", (int)notas.D, notas.E);
            }
        }

    }


}