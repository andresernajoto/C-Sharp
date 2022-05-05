using System;
using System.Globalization;
using System.Collections.Generic;
using GenericsRestriction.Services;
using GenericsRestriction.Entities;

namespace GenericsRestriction {
    class Program {
        static void Main(string[] args) {

            // instanciação de uma lista do tipo inteiro
            List<Product> list = new List<Product>();

            // leitura dos valores de repetição
            Console.Write("Enter N: ");
            int num = int.Parse(Console.ReadLine());

            // leitura, separação e adição dos valores à lista
            // foi separado o vetor em nome e salário e depois acrescentado ao construtor
            for (int i = 0; i < num; i++) {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            // instanciação da classe CalculationService
            CalculationService cs = new CalculationService();

            // atribuição do valor máximo
            Product max = cs.Max(list);

            // impressão dos dados
            Console.WriteLine();
            Console.WriteLine("The max value is: \n" + max);
        }
    }
}
