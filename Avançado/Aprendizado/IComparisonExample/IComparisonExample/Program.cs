using System;
using System.Collections.Generic;
using IComparisonExample.Entities;

namespace IComparisonExample {
    class Program {
        static void Main(string[] args) {

            // instanciação de uma lista do tipo Product
            List<Product> products = new List<Product>();

            // adição de produtos à lista
            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            // FORMA 1
            /* organizando a lista por nome (por meio da função)
            products.Sort(CompareProduct); */

            // FORMA 2
            /* Comparison<Product> comp = CompareProduct;
            products.Sort(comp); */

            // FORMA 3
            // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper();

            // FORMA 4
            // products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            // impressão de cada dado da lista
            foreach (Product p in products) {
                Console.WriteLine(products);
            }
        }

        // FORMA 1
        /* função que retorna a comparação entre produtos
        static int CompareProduct(Product p1, Product p2) {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        } */
        }
    }
