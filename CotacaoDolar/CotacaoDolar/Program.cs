using System;
using System.Globalization;


namespace CotacaoDolar {
    class Program {
        static void Main(string[] args) {

            /* leitura da cotação do dólar e
             da quantidade a ser comprada*/
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* variável que armazena os valores
             acima e faz a chamada do método que
            converte os valores inseridos*/
            double convertido = ConversorDeMoeda.CalculoConversor(cotacao, dolaresComprados);

            // apresentação dos valores na tela
            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = R$ " + convertido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
