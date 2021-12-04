namespace UpAndDownCasting.Entities {
    // herda da Account
    class SavingsAccount : Account {

        // declaração da propriedade da classe
        public double InterestRate { get; set; }

        // construtor padrão
        public SavingsAccount() { }

        // construtor que recebe os dados da Account mais o InterestRate
        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance) {

            InterestRate = interestRate;
        }

        /* método que mostra o salário atualizado, ou seja,
         multiplica o salário pelo juros e soma a si mesmo */
        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }
    }
}
