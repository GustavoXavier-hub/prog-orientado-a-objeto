using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Conversoes2
    {
        static void Main(string[] args)
        {

            {
                string S = "99"; 
                int I = Convert.ToInt16(S); 
                I = I + 1;
                Console.Clear(); 
                Console.WriteLine(I); 
                string X = Convert.ToString(I);
                Console.WriteLine(X + "tem " + X.Length + " dígitos");
            }


        }
    }
}
