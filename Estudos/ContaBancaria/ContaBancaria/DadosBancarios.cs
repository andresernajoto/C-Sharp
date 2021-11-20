using System.Globalization;

namespace ContaBancaria {
    class DadosBancarios {

        // declaração dos atributos com auto-properties
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        // construtor com titular e numero da conta
        public DadosBancarios(int numeroConta, string titular) {
            NumeroDaConta = numeroConta;
            Titular = titular;
        }

        // construtor com todos os dados
        public DadosBancarios(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular) {
            /* para melhor manutenção do programa
            é melhor utilizar o método de depósito
            recebendo o depósito inicial */
            DepositoBancario(depositoInicial);
        }

        // método de depósito
        public double DepositoBancario(double dep) {
            return Saldo += dep;
        }

        // método de saque
        public double SaqueBancario(double dep) {
            return Saldo -= dep + 5;
        }
        /* override do ToString para
        mostrar o resultado na tela*/ 
        public override string ToString() {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
