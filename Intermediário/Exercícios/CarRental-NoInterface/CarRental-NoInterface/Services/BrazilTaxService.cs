namespace CarRental_NoInterface.Services {
    class BrazilTaxService {

        // operação que calcula a taxa de rental
        public double Tax(double amount) {
            if (amount <= 100) {
                return amount * 0.2;
            } else {
                return amount * 0.15;
            }
        }
    }
}
