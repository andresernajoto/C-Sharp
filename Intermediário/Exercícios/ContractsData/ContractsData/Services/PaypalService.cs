namespace ContractsData.Services {
    class PaypalService : IOnlinePaymentService {

        // declaração das constantes da taxa paga
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        // DETALHE: foi herdado do IOnline seus métodos
        // calcula a taxa mensal a ser cobrada
        public double Interest(double amount, int months) {
            return amount * MonthlyInterest * months;
        }

        // calcula a taxa de pagamento padrão a ser cobrada
        public double PaymentFee(double amount) {
            return amount * FeePercentage;
        }
    }
}
