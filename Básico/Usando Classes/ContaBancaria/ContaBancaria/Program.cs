using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe
            DadosBancarios dados;

            /* leitura do número da conta do titular
            por meio de uma variável que vai entrar
            no construtor estabelecido na classe. O
            mesmo se repete abaixo */
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            // leitura do nome do titular
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            // leitura da resposta sobre o depósito Inicial
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower()) ;

            /* se houver depósito inicial, então
            inserir o valor do depósito e armazenar
            no construtor da classe que recebe todas
            as informações (numero da conta, titular e deposito).
            Caso contrário, chamar o construtor que não recebe
            a quantidade depósitada*/
            if (resposta == 's') {
                Console.Write("Entre o valor de depósito inicial: R$ ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados = new DadosBancarios(numero, titular, depositoInicial);
            } else {
                dados = new DadosBancarios(numero, titular);
            }

            // apresentação dos dados
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(dados);
            Console.WriteLine();

            /* leitura do valor de depósito e
            implementação do método para somar
            o depósito inicial com o atual*/
            Console.Write("Entre com um valor para depósito: R$ ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.DepositoBancario(dep).ToString("F2", CultureInfo.InvariantCulture);
            
            // apresentação dos dados
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(dados);
            Console.WriteLine();

            /* leitura do valor de saque e 
             implementação do método que subtrai
            o valor atual da conta com o valor
            sacado pelo titular da conta */
            Console.Write("Entre com um valor para saque: R$ ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.SaqueBancario(dep).ToString("F2", CultureInfo.InvariantCulture);
            
            // apresentação final dos dados
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(dados);
        }
    }
}
