using System;
using System.Globalization;

namespace UsingClasses {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Enter the sides of the X triangle: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Enter the sides of the Y triangle: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.WriteLine();

            Console.WriteLine("Area of X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

            if (areaX > areaY) {
                Console.WriteLine("The biggest area is: X");
            } else {
                Console.WriteLine("The biggest area is: Y");
            }

        }
    }
}
