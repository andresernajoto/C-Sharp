using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using LinqExercise1.Entities;


namespace LinqExercise1 {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string productName = line[0];
                        double productPrice = double.Parse(line[1], CultureInfo.InvariantCulture);

                        list.Add(new Product(productName, productPrice));
                    }
                }

                var avg = list
                    .Select(x => x.Price)
                    .DefaultIfEmpty(0.0)
                    .Average();

                var namesList = list
                    .Where(x => x.Price < avg)
                    .OrderByDescending(x => x.Name)
                    .Select(x => x.Name);

                Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string name in namesList) {
                    Console.WriteLine(name);
                }

            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
