namespace UpAndDownCasting.Entities {
    // herdado da Account
    class BusinessAccount : Account {

        // declaração da propriedade da classe
        public double LoanLimit { get; set; }

        // construtor padrão
        public BusinessAccount() { }

        // construtor que herda os valores da Account e acrescenta o LoanLimit
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) {

            LoanLimit = loanLimit;
        }

        // método que calcula o limite de empréstimo
        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
}
