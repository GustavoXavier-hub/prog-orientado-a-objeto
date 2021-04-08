using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class ValidacaoString
    {
       public  static void Main(string[] args)
        {
            {
                const string Resp1 = "SIM", Resp2 = "NAO"; 
                const string Pergunta = "Mais nomes? "; 
                int I = -1, ContaA = 0; string Rperg = ""; 
                string[] Dados = new string[20];
                Boolean Er = true;
                do
                    try
                    {
                        I++; Console.Write("Nome ");
                        Dados[I] = Console.ReadLine();
                        Console.Write(Pergunta); Rperg = Console.ReadLine().ToUpper();
                        if (Rperg != Resp1 && Rperg != Resp2)
                            throw new Exception();
                    }
                    catch
                    {
                        Er = true;
                        while (Er == true)
                        {
                            Console.WriteLine("Responda SIM ou NAO "); 
                            Console.Write(Pergunta); Rperg = Console.ReadLine().ToUpper();
                            Er = (Rperg != Resp1 && Rperg != Resp2);
                        }
                    }
                    finally
                    {
                        if (Dados[I].Substring(0, 1).ToUpper() == "A")
                            ContaA++;
                    }
                while (Rperg == Resp1);
                Console.WriteLine("Digitou {0} nomes começados por A", ContaA);
            }
            Console.WriteLine("Digitou {0} nomes começados por A", ContaA);
        }
        
        }
    }

