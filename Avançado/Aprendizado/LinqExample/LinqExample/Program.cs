using System;
using System.Linq;

namespace LinqExample {
    class Program {
        static void Main(string[] args) {

            // specify data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // define query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // execute query
            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}
