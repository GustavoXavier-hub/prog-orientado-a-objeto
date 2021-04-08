using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class ValidaPassword
    {
        static void Main(string[] args)
        {
            {
                const int Limite = 3; 
                string Password = "ABCDE";
                Console.Write("Password:"); 
                ConsoleKeyInfo C; string Dig;
                int Tenta = 0; 
                bool Invalida = true;
                while (Invalida == true && Tenta < Limite)
                {
                    Dig = "";
                    try
                    {
                        for (int I = 0; I < Password.Length; I++)
                        {
                            C = Console.ReadKey(true);
                            Console.SetCursorPosition(10 + I, Console.CursorTop); 
                            Console.Write("*"); Dig += C.KeyChar.ToString();
                            Invalida = (Password != Dig); 
                            if (Invalida)
                           throw new Exception();
                        }
                    }
                    catch 
                    {
                        Tenta++; 
                        Console.Clear();
                        Console.Write("Password:");
                    }
                    if (Tenta >= Limite)
                        Console.WriteLine("\n Esgotou o número de tentativas");
                    else
                        Console.WriteLine("\nPalavra-chave válida");
                }
            }
        }
    }
}
