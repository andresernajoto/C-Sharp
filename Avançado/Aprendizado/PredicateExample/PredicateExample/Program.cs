using System;
using System.Collections.Generic;
using PredicateExample.Entities;

namespace PredicateExample {
    class Program {
        static void Main(string[] args) {

            // instanciação de uma lista de produtos
            List<Product> list = new List<Product>();

            // adição dos produtos à lista
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // remoção dos produtos de acordo com a função
            list.RemoveAll(ProductTest);

            // impressão de cada produto adicionado à lista
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
        }

        // função que retorna somente os produtos maiores que 100
        public static bool ProductTest(Product p) {
            return p.Price >= 100;
        }
    }
}
