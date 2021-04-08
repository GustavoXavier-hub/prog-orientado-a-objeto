using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class HistoricoErros
    {
        static void Main(string[] args)
        {
            {
                string Historico = "";
                int N = 4; int[] A = new int[N];
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
                            Historico += "Negativo - substituímos por 10 \n"; A[I] = 10;
                        }
                        finally
                        {
                            Historico += "Multiplicámos por 100 \n"; A[I] *= 100;
                        }

                    }
                    catch
                    {
                        Historico += "Caracter, string ou real"; Historico += " - substituímos por 20 \n"; A[I] = 20;
                    }
                    finally
                    {
                        Historico += "Multiplicámos por 5"; A[I] *= 5; Historico += " A[" + I + "] passa a ser " + A[I] + "\n";
                    }
                    Console.WriteLine(Historico);
                }

            }
        }
    }
}
