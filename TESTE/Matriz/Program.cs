using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class y { public int j { get; set; } }

    class quartos { 
     public hospedes h { get; set; }

    }
    class hospedes { 
     public string Nome { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mi = new int[10];
            //string[] ms = new string[3];

            List<quartos> listaQuartos = new List<quartos>();
            const int numquartos = 5;
            int[] hotel2 = new int[numquartos];
            quartos[] hotel = new quartos[numquartos];

            for (int i = 0; i < hotel.Length; i++)
            {
                quartos q = new quartos();
                hotel[i] = q;
            }

            try
            {
                foreach (quartos q2 in hotel)
                {
                    Console.WriteLine(q2.h.Nome);
                }

                //linq
                var x = hotel.ToList();
                var y = x.FirstOrDefault(o => o.h.Nome == "Gustavo");

                foreach (quartos q in hotel)
                {
                    hospedes h = new hospedes();
                    h.Nome = "Nome" + DateTime.Now.Millisecond.ToString();
                    q.h = h;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO"+ ex.Message);
            }

            //y[] my = new y[4];

            //for (int i = 0; i < my.Length; i++)
            //{
            //    y o = new y();
            //    o.j = i;
            //    my[i] = o;

            //}

            //foreach (y o1 in my)
            //{
            //    Console.WriteLine(o1.j);
            //}



            //ms[0] = "s0"; ms[1] = "s1"; ms[2] = DateTime.Now.Millisecond.ToString();
            //for (int i = 0; i < mi.Length; i++)
            //    Console.WriteLine(ms[i]);

            //for (int i = 0; i < mi.Length; i++) mi[i] = i;
            //for (int i = 0; i < mi.Length; i++) 
            //Console.WriteLine(mi[i]);



        }
    }
}
