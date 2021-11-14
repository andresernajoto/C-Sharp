using System.Globalization;

namespace AumentoSalarial {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        // retorna o cálculo do salário líquido
        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        // retorna o ajuste de aumento salarial
        public double AumentarSalario(double aumento) {
            return SalarioBruto / aumento  + SalarioLiquido();
        }

        public override string ToString() {
            return Nome
                + ", $ ";
        }
    }
}
