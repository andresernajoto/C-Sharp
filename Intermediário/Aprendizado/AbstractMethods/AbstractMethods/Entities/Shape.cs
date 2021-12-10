using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities {
    // classe abstrata
    abstract class Shape {

        // propriedade da classe do tipo Enumerado
        public Color Color { get; set; }

        // construtor que recebe uma cor enumerada
        public Shape(Color color) {
            Color = color;
        }

        // método abstrato que não tem implementação
        public abstract double Area();
    }
}
