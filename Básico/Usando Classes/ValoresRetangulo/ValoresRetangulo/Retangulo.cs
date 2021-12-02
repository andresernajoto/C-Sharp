using System;

namespace ValoresRetangulo {
    class Retangulo {

        // criação dos atributos
        public double Largura;
        public double Altura;

        // realiza o cálculo da área
        public double Area() {
            return Largura * Altura;
        }

        // realiza o cálculo do perímetro
        public double Perimetro() {
            return (Largura * 2) + (Altura * 2);
        }

        // realiza o cálculo da diagonal
        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + (Altura * Altura));
        }
    }
}
