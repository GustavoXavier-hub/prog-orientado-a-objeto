using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Conversoes1
    {
        static void Main(string[] args)
        {
            {
                double D = 99.56;
                int I = (int)D; 
                Console.WriteLine(D + " e " + I); 
                I = 100; D = I;
                Console.WriteLine(D + " e " + I);
            }


        }
    }
}
