using System;
using System.Globalization;

namespace ValoresRetangulo {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe
            Retangulo ret = new Retangulo();

            // leitura da altura e largura do retângulo
            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // saída exibida na tela
            Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
