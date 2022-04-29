using InheritanceAndInterface.Model.Enums;

namespace InheritanceAndInterface.Model.Entities {
    abstract class AbstractShape : IShape {
        
        // definição a cor para que ela seja reaproveitada
        public Color Color { get; set; }

        // implementação abstrata do método, mantendo de forma abstrata
        public abstract double Area();
    }
}
