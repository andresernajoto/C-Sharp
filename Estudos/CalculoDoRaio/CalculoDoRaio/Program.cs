using System;
using System.Globalization;

namespace CalculoDoRaio {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe
            Calculadora calc = new Calculadora();

            // leitura do valor do raio
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* armazenamento dos valores
             utilizando uma variável que
            chama o método da classe*/
            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);

            /* apresentação dos valores na tela
            com formatação do ponto (.)*/
            Console.WriteLine();
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
