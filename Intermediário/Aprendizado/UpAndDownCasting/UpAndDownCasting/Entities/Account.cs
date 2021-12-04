namespace UpAndDownCasting.Entities {
    class Account {

        // declaração das propriedades da classe
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        // construtor padrão
        public Account() { }

        // construtor que recebe o número da conta, nome e saldo do titular
        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // método que saca o dinheiro da conta
        public void Withdraw(double amount) {
            Balance -= amount;
        }

        // método que deposita dinheiro na conta
        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
