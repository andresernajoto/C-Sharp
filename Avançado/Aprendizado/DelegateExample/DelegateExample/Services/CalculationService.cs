namespace DelegateExample.Services {
    class CalculationService {

        // retorna um valor máximo entre x e y
        public static double Max(double x, double y) {
            return (x > y) ? x : y;
        }

        // retorna a soma de x e y
        public static double Sum(double x, double y) {
            return x + y;
        }

        // retorna o dobro de x
        public static double Square(double x) {
            return x * x;
        }
    }
}
