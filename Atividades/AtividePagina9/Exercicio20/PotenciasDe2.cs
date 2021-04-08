using System;

namespace Exercicio20
{
    class Ackermann
    {
        static int Acker(int m, int n)
        {
            {
                if (m == 0) return 1;
                else
                if (m == 1 && n == 0) 
                return 2;
                else 
                if (m > 1 && n == 0)
                return m + 2;
                else
                return Acker(Acker(m - 1, n), n - 1);
            }
        }
        static void Main(string[] args)
        {
            int m = 1, n = 0;
            Console.WriteLine("Ackermann({0},{1})={2}", m, n, Acker(m, n));
            m = 3; n = 0; Console.WriteLine("Ackermann({0},{1})={2}", m, n, Acker(m, n));
            m = 4; n = 3; Console.WriteLine("Ackermann({0},{1})={2}", m, n, Acker(m, n));
        }
    }
}
