using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class ValidaCateg
    {
        static void Main(string[] args)
        {
            {
                Char Categ = ' '; 
                bool Valida = false; 
                while (Valida == false)
                    try
                    {
                        Console.Write("Categoria profissional >"); 
                        Categ = Convert.ToChar(Console.ReadLine()); 
                        Valida = Categ >= 'C' && Categ <= 'E'; 
                        if (Valida == false) 
                        throw new Exception();
                    }
                    catch 
                    {
                        Console.WriteLine("Digite C, D ou E");
                    }
                Console.WriteLine("categoria validada: {0} ", Categ);
            }
        }
    }
}
