using System;
using DelegateExample.Services;

namespace DelegateExample {

    // função delegate que retorna dois valores double
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program {
        static void Main(string[] args) {

            // valores
            double a = 10;
            double b = 12;

            // aplicação das funções da classe CS para o delegate
            BinaryNumericOperation op1 = CalculationService.Sum;
            BinaryNumericOperation op2 = CalculationService.Max;

            // apresentação do resultado
            double result = op1(a, b);
            Console.WriteLine("Soma dos valores: " + result);

            // apresentação do resultado
            result = op2(a, b);
            Console.WriteLine("O maior valor encontrado é: " + result);
        }
    }
}
