using System;
using System.Globalization;
using BankAccount.Entities;
using BankAccount.Entities.Exceptions;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {
            
            // leitura dos dados da conta
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: $ ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: $ ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // armazenamento dos dados na classe Account
            Account account = new Account(num, holder, balance, withdrawLimit);

            // leitura do valor a ser sacado
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: $ ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // tentará aplicar o novo saldo
            try {
                account.WithDraw(amount);
                Console.WriteLine("New balance: $ {0}", account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                // caso haja uma exceção, aplicar o que está em Account
            } catch (DomainException e) {
                Console.WriteLine("Withdraw error: {0}", e.Message);
                // caso haja uma exceção de formato, aplicar a mensagem da classe
            } catch (FormatException e) {
                Console.WriteLine("Format error: {0}", e.Message);
            }
        }
    }
}
