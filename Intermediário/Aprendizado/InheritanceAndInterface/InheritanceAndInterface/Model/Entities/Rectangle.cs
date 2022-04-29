using System;
using System.Globalization;

namespace InheritanceAndInterface.Model.Entities {
    // a classe Rectangle herda a cor de Shape
    class Rectangle : AbstractShape {

        // atributos da classe
        public double Width { get; set; }
        public double Height { get; set; }

        // método abstrato de Shape sendo sobrescrito
        public override double Area() {
            return Width * Height;
        }

        // ToString sendo sobrescrito para apresentar os dados
        public override string ToString() {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
