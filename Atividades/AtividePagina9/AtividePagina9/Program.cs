using System;

namespace AtividePagina9
{
    class PotenciasDe2
    {
        static long PotenciaDe2(int E)
        {
            {
                if (E == 0)
                    return 1;
                else
                    return 2 * PotenciaDe2(E - 1);
            }
        }
        static void Main(string[] args)
        {
            {
                Console.Write("Expoente da potência de 2 (entre 0 e 62) ");
                int Expo = Convert.ToInt16(Console.ReadLine());
                while (Expo < 0 || Expo > 62)
                {
                    Console.Write("Expoente da potência de 2 (entre 0 e 62) ");
                    Expo = Convert.ToInt16(Console.ReadLine());
                }
                long Pot = PotenciaDe2(Expo);
                Console.WriteLine("2 elevado a {0} = {1}", Expo, Pot);
            }
        }
    }

    }
