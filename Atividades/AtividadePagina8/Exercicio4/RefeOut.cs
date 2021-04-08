using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class RefeOut
    {
        static void PotRef(ref double X, int Expoente)
        {
            {
                X = Math.Pow(X, Expoente);
            }
        }
        static void PotOut(out double Z, int Expoente)
        {
            Z = 3; Z = Math.Pow(Z, 3);
        }
        static void Main(string[] args)
        {
            double X = 4; int Expoente = 3; 
            double Z; Console.WriteLine("Valor original de X={0}", X);
            Console.WriteLine("Z não foi inicializado"); 
            Console.WriteLine("Valor original do expoente={0}", Expoente); 
            PotRef(ref X, Expoente); 
            PotOut(out Z, Expoente); 
            Console.WriteLine("X levantado ao expoente={0}", X);
            Console.WriteLine("Z levantado ao expoente={0}", Z); 
            Console.WriteLine("Valor final de X={0}", X); 
            Console.WriteLine("Valor final de Z={0}", Z); 
            Console.WriteLine("Valor final do expoente={0}", Expoente);
        }
    }
}
