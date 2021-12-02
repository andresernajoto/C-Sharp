using System;
using System.Globalization;

namespace UsingArray {
    class Program {
        static void Main(string[] args) {

            // declaração do número de repetições e soma
            int num = int.Parse(Console.ReadLine());
            double sum = 0.0;
            Console.WriteLine();

            // instanciação da classe produto como vetor
            Product[] vect = new Product[num];

            /* laço de repetição para ler os dados do
             produto, nome e preço, e calcular a soma
            dos preços de cada produto digitado */
            for (int i = 0; i < num; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                /* a linha abaixo usa os atributos da
                 classe Product e faz ele receberem os
                dados digitados dentro do programa principal */
                vect[i] = new Product { Name = name, Price = price };
                /* para acessar somente o valor do preço
                 do produto, é colocado um '.' e o nome
                do atributo desejado */
                sum += vect[i].Price;
            }

            // armazenamento da média dos produtos
            double average = sum / num;

            // apresentação dos dados na tela
            Console.WriteLine();
            Console.WriteLine("The average price is: R$ " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
