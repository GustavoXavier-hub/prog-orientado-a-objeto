using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class MaiorEMenorDe3
    {
        static void Main(string[] args)
        {
            {
                int X, Y, Z; Console.Write("Digite o primeiro valor (X) ");
                X = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Digite o segundo valor (Y) "); 
                Y = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Digite o terceiro valor (Z) "); 
                Z = Convert.ToInt16(Console.ReadLine()); 
                Console.WriteLine("Maior={0}", Maiorde3(X, Y, Z)); 
                Console.WriteLine("Menor={0}", Menorde3(X, Y, Z));
            }
        }
        static int Maiorde3(int X, int Y, int Z)
        {
            {
                if (X < Y)
                    X = Y;
                if (X < Z)
                    X = Z;
                return X;
            }
        }
        static int Menorde3(int X, int Y, int Z)
        {
            if (X > Y) 
            X = Y; 
            if (X > Z)
             X = Z; 
            return X;
        }

    }
}
