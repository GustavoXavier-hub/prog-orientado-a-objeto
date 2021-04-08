using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21
{
    class Inversaofrase
    {
        static string InversaoFrase(string X, int N)
        {
            {
                if (N == 0)
                return X;
                else
              return X.Substring(N, 1) + InversaoFrase(X.Substring(0, N), N - 1);
            }
        }

        static void Main(string[] args)
        {
            {
                string X = "adreuqse a arap atierid ad"; 
                int N = X.Length - 1; Console.WriteLine(InversaoFrase(X, N));
            }

        }
    }
}
