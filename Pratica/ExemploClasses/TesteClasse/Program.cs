using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace TesteClasse
{
    class Program
    {

        static void Main(string[] args)
        {

            MedidaMeteorologica met1 = new MedidaMeteorologica();
            met1.Temperatura = 27;
            met1.Umidade = 57;
            Console.WriteLine(met1.DevolvaMedida("met1"));

            MedidaMeteorologica met2 = new MedidaMeteorologica();
            met2.Temperatura = 26;
            met2.Umidade =45;
            Console.WriteLine(met2.DevolvaMedida("met2"));


            MedidaMeteorologica met3 = new MedidaMeteorologica();
            met2.TemperaturaFahrenheit = 96;
            met2.Umidade = 20;
            Console.WriteLine(met3.DevolvaMedida("met3"));

            MedidaMeteorologica met4 = new MedidaMeteorologica(15, 70);
            Console.WriteLine(met4.DevolvaMedida("met4"));

            Console.ReadKey();
        }
    }
}
