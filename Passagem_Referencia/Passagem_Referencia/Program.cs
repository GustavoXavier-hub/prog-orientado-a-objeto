using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem_Referencia
{
    class Program
    {
        static void PassagemReferencia(ref int X)
        {
            int b = 9;
            X = 7;
            Console.WriteLine("X={0}", X);
            
        }
        static void PassagemReferencia_OUT(out int X)
        {
            int b = 9;
            X = 7;
            Console.WriteLine("X={0}", X);
        }
        static void PassagemValor( int X)
        {
            X = 7;
            Console.WriteLine("X={0}", X);
        }

        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("a={0}", a);
            //PassagemReferencia(ref a);
            //PassagemValor(a);
            PassagemReferencia_OUT(out a);
            Console.WriteLine("a={0}", a);

        }
    }
}
