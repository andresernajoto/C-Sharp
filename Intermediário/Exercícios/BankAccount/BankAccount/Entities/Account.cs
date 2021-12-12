using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities {
    class Account {

        // declaração das propriedades da classe
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        // construtor padrão
        public Account() { }

        // construtor que recebe as propriedades
        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // método que acrescenta dinheiro à conta
        public void Deposit(double amount) {
            Balance += amount;
        }

        // método que remove dinheiro da conta
        public void WithDraw(double amount) {
            if (Balance < amount) {
                throw new DomainException("Not enough balance");
            }
            
            if (amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            
            Balance -= amount;
        }
    }
}
