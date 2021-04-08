using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class MedidaMeteorologica
    {
        // Atributos
        private double temperatura; // em Celsius
        private double umidade; // em % relativo

        // Propriedades
        public double Temperatura
        {
            get
            {
                return temperatura;
            }
            set
            {
                if (value >= -273.15)
                {
                    temperatura = value;
                }
                else
                {
                    Console.WriteLine("Não existe temperatura abaixo do zero absoluto.");
                }
            }
        }
        public double Umidade
        {
            get
            {
                return umidade;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    umidade = value;
                }
                else
                {
                    Console.WriteLine("A umidade relativa deve estar entre 0 e 100%.");
                }
            }
        }
        public double TemperaturaFahrenheit
        {
            get
            {
                return 1.8 * temperatura + 32;
            }
            set
            {
                Temperatura = (value - 32) / 1.8;
            }
        }

        // Métodos
        public string DevolvaMedida(string nome)
        {
            string saida = "";

            saida = "Medida " + nome + ": temperatura = " + Temperatura + ", temp. em Fahrenheit = "
                + TemperaturaFahrenheit + ", humidade = " + Umidade;

            return saida;
        }

        // Construtores
        public MedidaMeteorologica(double Temperatura, double Umidade)
        {
            this.Temperatura = Temperatura;
            this.Umidade = Umidade;
        }
        public MedidaMeteorologica()
        {
            // Esse não é um construtor padrão, é apenas um construtor sem parâmetros!!!
            Temperatura = 22;
            Umidade = 60;
        }
    }
}


