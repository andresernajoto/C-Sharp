using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractMethods.Entities;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods {
    class Program {
        static void Main(string[] args) {

            // leitura do número de repetições
            Console.Write("Enter the number of shapes: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // instanciação da lista do tipo Shape
            List<Shape> list = new List<Shape>();

            /* laço que faz a leitura da cor e,
             dependendo se for um retangulo ou
            circulo, lê a largura e comprimento
            ou o raio de um retângulo ou circulo */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Shape #{0} data:", i + 1);

                Console.Write("Rectangle or Circle (r/c)? ");
                char choice = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                
                /* condição que verifica a forma
                 e adiciona na lista de formas */
                if (choice == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                } else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                
                Console.WriteLine();
            }

            // apresentação de dados
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
