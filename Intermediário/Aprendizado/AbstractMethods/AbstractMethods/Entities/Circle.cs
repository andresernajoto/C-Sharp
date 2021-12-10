using System;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities {
    // herda de Shape
    class Circle : Shape {

        // declaração da propriedade da classe
        public double Radius { get; set; }

        // construtor que pega a base da Shape e adiciona a propriedade acima
        public Circle(double radius, Color color) : base(color) {
            Radius = radius;
        }

        // override do método abstrato da superclsse
        public override double Area() {
            return Math.PI * Radius * Radius;
        }
    }
}
