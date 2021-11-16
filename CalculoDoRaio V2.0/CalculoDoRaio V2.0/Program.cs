using System;
using System.Globalization;

namespace CalculoDoRaio_V2._0 {
    class Program {
        static void Main(string[] args) {

            // leitura do valor do raio
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* armazenamento das operações
            com uso de método estático*/
            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            /* apresentação dos valores na tela
            com formatação do ponto (.)*/
            Console.WriteLine();
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
