using System;

namespace Exercicio6
{
    class MaxDivComum
    {
        static int MDC(int X, int Y)
        {
            {
                if (X == Y)
               return X; 
                else 
                if (X > Y)
              return MDC(X - Y, Y);
             else return MDC(X, Y - X);
            }
        }
        static void Main(string[] args)
        {
            {
                Console.Write("Digite um inteiro ");
                int X = Convert.ToInt16(Console.ReadLine());
                Console.Write("Digite outro inteiro "); 
                int Y = Convert.ToInt16(Console.ReadLine()); 
                Console.WriteLine("MDC({0}, {1})={2}", X, Y, MDC(X, Y));
            }
        }
    }
}
