using System;

namespace Exercicio8
{

    class CapitalizacaoComposta
    {
        static double CapAcum(int Inicial, double Taxa, int N)
        {
            if (N == 0) 
            return Inicial;
            else 
           return CapAcum(Inicial, Taxa, N - 1) * (1 + Taxa);
        }

        static void Main(string[] args)
        {
            Console.Write("Capital inicial ");
            int Inicial = Convert.ToInt16(Console.ReadLine());
            Console.Write("Taxa anual de juro em % "); 
            double Taxa = Convert.ToDouble(Console.ReadLine()) / 100; 
            Console.Write("Duração da capitalização em anos "); 
            int N = Convert.ToInt16(Console.ReadLine()); Console.WriteLine("{0} euros capitalizados à taxa anual" + " de {1} durante {2} anos={3,5:f2} euros", Inicial, Taxa, N, CapAcum(Inicial, Taxa, N));
        }
    }
}
