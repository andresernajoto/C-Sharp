using System;
using System.Globalization;
using ContractsData.Entities;
using ContractsData.Services;

namespace ContractsData {
    class Program {
        static void Main(string[] args) {

            // maneira para encurtar o CultureInfo
            CultureInfo CI = CultureInfo.InvariantCulture;

            // leitura do número e mês do contrato
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CI);
            Console.WriteLine();

            // leitura do valor a ser pago e número de parcelas (meses)
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CI);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // instanciação do numero, data e valor do contrato na classe que armazena essas informações
            Contract myContract = new Contract(number, contractDate, contractValue);

            // instanciação do pagamento Paypal dentro do serviço do contrato
            ContractService contractService = new ContractService(new PaypalService());
            // adicionadno o contrato dentro do método, junto aos meses
            contractService.ProcessContract(myContract, months);

            // apresentação das informações por meio de foreach, apresentando cada parcela gerada no contrato
            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
}
