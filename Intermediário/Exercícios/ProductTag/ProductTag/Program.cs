using System;
using System.Globalization;
using System.Collections.Generic;
using ProductTag.Entities;

namespace ProductTag {
    class Program {
        static void Main(string[] args) {

            // leitura do número de repetições
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // declaração da lista de tipo Product
            List<Product> list = new List<Product>();

            /* laço de repetição que faz a leitura da
             tag, nome e preço do produto inserido */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Product #{0} data", i + 1);
                Console.Write("Common, used or imported (c/u/i)? ");
                char tag = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // condição que verifica a tag do produto
                if (tag == 'i') {
                    Console.Write("Customs Fee: ");
                    double cFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, cFee));
                } else if (tag == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                } else {
                    list.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            // apresentação dos dados
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
