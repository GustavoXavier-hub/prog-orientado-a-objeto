using System;

namespace Exercicio9
{
    class TabelamentoFx
    {
        static int TabelaF(int X)
        {
            {
                if (X <= 3)
               return 7;
                else 
               return TabelaF(X - 1) + 12;
            }
        }
        static void Main(string[] args)
        {
            string Tabela = "x".PadLeft(3) + "F(x)".PadLeft(6) + "\n";
            for (int X = 0; X <= 10; X++) 
            Tabela += Convert.ToString(X).PadLeft(3) + Convert.ToString(TabelaF(X)).PadLeft(5) + "\n"; 
            Console.WriteLine(Tabela);
        }
    }
}
