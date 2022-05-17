using System;

namespace MultiDelegates.Services {
    class CalculationService {

        // método que mostra o valor máximo entre x e y
        public static void ShowMax(double x, double y) {
            double max = (x > y) ? x : y;
            Console.WriteLine("O maior valor encontrado é: " + max);
        }

        // método que mostra a soma entre x e y
        public static void ShowSum(double x, double y) {
            double sum = x + y;
            Console.WriteLine("A soma entre os valores é: " + sum);
        }
    }
}
