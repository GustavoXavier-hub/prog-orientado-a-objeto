using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class NotasEntre0e20
    {
        static int LeValida(int I)
        {
            int N = 0;
            bool Valida = false;
            while (Valida == false)
                try
                {
                    Console.Write("Nota do aluno {0}=", I + 1); 
                    N = Convert.ToInt16(Console.ReadLine());
                    Valida = N >= 0 && N <= 20;
                    if (Valida == false) 
                    throw new Exception();
                }
                catch 
                {
                    Console.WriteLine("A nota e um número inteiro igual ou" + "superior a 0 e inferior ou igual a 20");

                }
            return N;
        }

        static void Main(string[] args)
        {
            {
                int[] X = new int[5]; 
                for (int I = 0; I <= X.Length - 1; I++)
                {
                    X[I] = LeValida(I);
                }
                Console.WriteLine("Notas lidas: "); 
                for (int I = 0; I <= X.Length - 1; I++)
                {
                    Console.WriteLine(I + 1 + "--" + X[I]);
                }
            }
        }
    }
}
