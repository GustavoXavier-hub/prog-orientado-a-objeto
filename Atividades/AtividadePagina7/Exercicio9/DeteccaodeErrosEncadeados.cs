using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class DeteccaodeErrosEncadeados
    {
        static void Main(string[] args)
        {
            {
                int N = 4; 
                int[] A = new int[N]; 
                for (int I = 0; I <= N - 1; I++)
                {
                    try
                    {
                        Console.Write("Digite a[{0}] ", I); 
                        A[I] = Convert.ToInt16(Console.ReadLine());
                        try
                        {
                            if (A[I] < 0) 
                           throw new Exception();
                        }
                        catch
                        {
                            Console.WriteLine("Negativo substituímos por 10"); A[I] = 10;
                        }
                        finally
                        {
                            Console.WriteLine("Multiplicámos por 100"); A[I] *= 100;
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("Carácter, string ou real- substituímos por 20");
                        A[I] = 20;
                    }
                    finally
                    {
                        Console.WriteLine("Multiplicámos por 5"); 
                        A[I] *= 5; Console.WriteLine("a[{0}] passa a ser {1}", I, A[I]);
                    }  
                }
                Console.WriteLine("\n Vector:");
                foreach (int I in A)
                 Console.WriteLine(I);
            }
        }
    }
}
