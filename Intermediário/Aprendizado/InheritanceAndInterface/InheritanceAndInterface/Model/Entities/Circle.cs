using System;
using System.Globalization;

namespace InheritanceAndInterface.Model.Entities {
    // a classe Circle herda a cor de Shape
    class Circle : AbstractShape {

        // atributo da classe
        public double Radius { get; set; }

        // método abstrato sendo sobrescrito
        public override double Area() {
            return Math.PI * Radius * Radius;
        }

        // ToString sendo sobrescrito para apresentar os dados
        public override string ToString() {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
