using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class OrdemTres
    {
        static void Main(string[] args)
        {
            {

                Console.Write("Digite o primeiro número ");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo número ");
                double B = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o terceiro número ");
                double C = Convert.ToDouble(Console.ReadLine());
                double Menor, Meio = 0, Maior = 0;
                if (A > B)
                {
                    if (A > C)
                    {
                        Maior = A;
                        if (B > C)
                        {
                            Meio = B;
                            Menor = C;
                        }
                        else
                        {
                            Meio = C;
                            Menor = B;
                        }
                    }
                    else
                    {
                        Maior = C;
                        Meio = A;
                        Menor = B;
                    }
                }
                else
                {
                    if (B > C)
                    {
                        Maior = B;
                        if (A > C)
                        {
                            Meio = A;
                            Menor = C;
                        }
                        else
                        {
                            Meio = C;
                            Menor = A;
                        }
                    }
                    else
                    {
                        Maior = C;
                        Meio = B;
                        Menor = A;
                    }
               }
                Console.WriteLine("{0}<{1}<{2}", Menor, Meio, Maior);
            }


            }
                    
                  }


        }

    


