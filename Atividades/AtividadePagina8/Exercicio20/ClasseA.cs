using Exercicio20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{

    class ClasseC
    {
        public static string Filosofo()
        {
            { return "\nSócrates"; }
        }
        private static string OutroFilosofo()
        { return "Kant"; }
    }
}
    class ClasseB
    {
        public static string Maxima1()
        {
            {
                string M1 = "Não sou ateniense nem grego, "; 
                string M2 = Maxima2(); 
                string M3 = ClasseC.Filosofo();
                //Console.WriteLine(ClasseC.OutroFilosofo()); 
                return M1 + M2 + M3;
            }
        }
        private static string Maxima2() { return "mas sim um cidadão do mundo"; }
    }

    class ClasseA
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(ClasseB.Maxima1());
                //Console.WriteLine(ClasseC.OutroFilosofo()); 
            }
        }
    }


