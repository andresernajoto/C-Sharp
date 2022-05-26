using System;
using System.Collections.Generic;
using FuncExample.Entities;
using System.Linq;

namespace FuncExample {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 89.90));

            // aplica a função NameUpper na lista
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result) {
                Console.WriteLine(s);
            }
        }
    }
}
