using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class VectorDeLetras
    {
        static void Main(string[] args)
        {

            {
                int N = 16; char Letra = 'A';
                char[] Letras = new char[N]; 
                for (int I = 0; I <= N - 1; I++)
                {
                    Letras[I] = Letra; 
                    Letra++;
                }
                foreach (char Elemento in Letras)
                Console.Write("{0, 3}", Elemento); 
                Console.WriteLine();
            }
        }
    }
}
