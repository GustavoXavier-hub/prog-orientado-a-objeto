using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pagina1
{
    public class EstudanteInf
    {
        private string Nome;
        private double Teste1;
        private double Teste2;
        public EstudanteInf(String N, double T1, double T2)
        {
            Nome = N;
            Teste1 = T1;
            Teste2 = T2;
        }
        public double ClassFinal()
        {
            return Math.Round((Teste1 + Teste2) / 2, 0, MidpointRounding.AwayFromZero);
        }

        public string LerNome()
        {
            return Nome;
        }
            
        public class ClassificacaoFinal
        {
            static void Main(string[] args)
            {
                EstudanteInf A = new EstudanteInf("Joana", 13, 14);
                Console.WriteLine("Classificação final= " + A.ClassFinal());
            }
        }

        public class NomeENota
        {
            static void Main(string[] args)
            {
                EstudanteInf A = new EstudanteInf("Joana Pinto", 13, 14);
                Console.WriteLine("{0,-20} {1,-10}", "Aluno", "Classificação"); 
                Console.WriteLine("{0,-20} {1,8}", A.LerNome(), A.ClassFinal());
            }
        }

        


    }
}
