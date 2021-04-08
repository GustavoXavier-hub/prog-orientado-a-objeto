using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class OperacoesLogicas
    {
        //óperaçõs logicas
        //operaçãõ AND &&  ou &
        //operaçao OR || ou |
        //operaçao Not !

        static void Main(string[] args)
        {
            int x = 3, y = 4, z = 5;
            bool v1 = false;

            //#region AND
            //if (x == 3 && y >= 4)
            //{
            //    Console.WriteLine("Verdade");
            //}
            //else
            //    Console.WriteLine("Falso");

            //if (x != 3 && y >= 4)
            //{
            //    Console.WriteLine("Verdade");
            //}
            //else
            //    Console.WriteLine("Falso");
            //#endregion

            //#region OR
            //if (x == 3 || y >= 4)
            //{
            //    Console.WriteLine("Verdade");
            //}
            //else
            //    Console.WriteLine("Falso");

            //if (x != 3 || y >= 4)
            //{
            //    Console.WriteLine("Verdade");
            //}
            //else
            //    Console.WriteLine("Falso");
            //#endregion


            //#region  AND && E &
            //if ((x !=3) && (v1=y>=4))
            //{
            //    Console.WriteLine("Verdade");
            //}
            //else
            //    Console.WriteLine("Falso");

            //Console.WriteLine("v1={0}", v1);

            //if ((x != 3) && (v1 = y >= 4))
            //{
            //    Console.WriteLine("Verdade");
            //}
            //else
            //    Console.WriteLine("Falso");

            //Console.WriteLine("v1={0}", v1);
            //#endregion

            #region AND
            if ((x == 3) && (y>= 4) && z==6)
            {
                Console.WriteLine("Verdade");
            }
            else
                Console.WriteLine("Falso");


            #endregion

            #region OR
            if (!(x == 3) || (y >= 4) || z == 5)
            {
                Console.WriteLine("Verdade");
            }
            else
                Console.WriteLine("Falso");
            #endregion



        }
    }
}
