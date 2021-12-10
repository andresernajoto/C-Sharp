using System;
using System.Globalization;
using System.Collections.Generic;
using TaxPayers.Entities;

namespace TaxPayers {
    class Program {
        static void Main(string[] args) {

            // leitura do número de repetições
            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // instanciação de uma lista Payer
            List<Payer> list = new List<Payer>();

            /* laço que faz a leitura do nome e taxa anual
             de uma pessoa física e jurídica e aplica um
            terceiro elemento dependendo de quem for */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Tax payer #{0} data:", i + 1);
                
                Console.Write("Invidual or company (i/c)? ");
                char choice = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                /* condição que verifica qual o tipo de 
                 pessoa para aplicar o cálculo de imposto */
                if (choice == 'i') {
                    Console.Write("Health Expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(name, annualIncome, healthExpenses));
                } else {
                    Console.Write("Number of employees: ");
                    int numOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new LegalEntity(name, annualIncome, numOfEmployees));
                }

                Console.WriteLine();
            }

            // apresentação das taxas pagas pelos Payers
            Console.WriteLine("TAXES PAID:");
            foreach (Payer p in list) {
                Console.WriteLine("{0}: $ {1}", p.Name, p.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            // soma de todas as taxas
            Console.WriteLine();
            double tax = 0.0;
            foreach (Payer p in list) {
                tax += p.Tax();
            }

            // apresentação da soma de todas as taxas
            Console.WriteLine("TOTAL TAXES: $ {0}", tax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
