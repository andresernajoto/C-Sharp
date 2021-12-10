using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities {
    // herda de Shape
    class Rectangle : Shape {

        // declaração das propriedades da classe
        public double Width { get; set; }
        public double Height { get; set; }

        // construtor que pega a base da Shape e adiciona as propriedades acima
        public Rectangle(double width, double height, Color color)
            : base(color) {
            Width = width;
            Height = height;
        }

        // override do método abstrato da superclsse
        public override double Area() {
            return Width * Height;
        }
    }
}
