using MultiDelegates.Services;

namespace MultiDelegates {

    // declaração do delegate
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program {
        static void Main(string[] args) {

            // valores
            double a = 10;
            double b = 12;

            // chamada do delegate com multicast
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            // apresentação dos métodos em ordem de chamada
            op.Invoke(a, b);
        }
    }
}
