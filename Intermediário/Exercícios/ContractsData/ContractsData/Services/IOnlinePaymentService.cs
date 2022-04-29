namespace ContractsData.Services {
    interface IOnlinePaymentService {

        // métodos da classe que serão herdados pelo Paypal
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
