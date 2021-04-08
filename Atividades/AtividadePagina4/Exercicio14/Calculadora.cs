using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Operando 1? "); 
                int X = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Operando 2? "); 
                int Y = Convert.ToInt16(Console.ReadLine()); 
                Console.Write("Operação +, - , * /? "); 
                char Operador = Convert.ToChar(Console.ReadLine()); 
                double Resul = 0;
                switch (Operador)
                {
                case '+': 
                Resul = X + Y; 
                break;
                case '-': 
                Resul = X - Y; 
                break;
                case '*': 
                Resul = X * Y; 
                break;
                case '/': 
                Resul = (double)X / Y; 
                break;
                }
                Console.WriteLine("{0}{1}{2}={3}", X, Operador, Y, Resul);
            }


        }
    }
}
