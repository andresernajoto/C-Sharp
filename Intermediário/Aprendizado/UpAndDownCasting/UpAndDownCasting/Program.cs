using System;
using UpAndDownCasting.Entities;

namespace UpAndDownCasting {
    class Program {
        static void Main(string[] args) {
            
            // instanciação das classes recebendo seus valores
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            // UPCASTING
            /* faz a conversão de uma subclasse para superclasse */

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            /* faz a conversão de uma superclasse para subclasse */

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            /* a linha abaixo apresenta erro pois não
             é possível uma subclasse instancia outra */
            // BusinessAccount acc5 = (BusinessAccount)acc3;

            /* usamos o 'is' para saber se aquele
             objeto é ou não o que procuramos */
            if (acc3 is BusinessAccount) {
                // primeira forma de fazer um casting
                // BusinessAccount acc5 = (BusinessAccount)acc3;

                // segunda forma
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);

                Console.WriteLine("Loan!");
            }

            // verifica se o 'acc3' é do tipo SavingsAccount
            if (acc3 is SavingsAccount) {
                // primeira forma de fazer um casting
                // SavingsAccount acc5 = (SavingsAccount)acc3;

                // segunda forma
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();

                Console.WriteLine("Update!");
            }
        }
    }
}
