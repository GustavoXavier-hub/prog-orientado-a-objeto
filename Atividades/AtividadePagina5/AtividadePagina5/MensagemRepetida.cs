using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePagina5
{
    class MensagemRepetida
    {
        static void Main(string[] args)
        {
            {
                const string mensagem = "Bem-Vindo ao C# !";
                for (int I = 1; I <= 10; I++)
                    Console.WriteLine(mensagem);
            }
        }
    }
}
