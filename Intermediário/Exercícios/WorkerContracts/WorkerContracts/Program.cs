using System;
using System.Globalization;
using WorkerContracts.Entities;
using WorkerContracts.Entities.Enums;

namespace WorkerContracts {
    class Program {
        static void Main(string[] args) {

            // leitura do departamente do trabalhador
            Console.Write("Enter the department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();

            // leitura do nome
            Console.WriteLine("Enter the worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            /* conversão do nível do trabalhador
             de string para o tipo enum, com
            leitura do nível e abaixo a do salário
            base */
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: R$ ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* instanciação do departamento
             do trabalhador e dos dados dele */
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            /* laço que faz a leitura do
             contrato do trabalhador */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Enter {0} contract data:", i + 1);

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: R$ ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // instanciação do contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);

                // método que adiciona os dados ao contrato
                worker.AddContract(contract);
            }

            /* leitura da data do income e a subdivisão
             e armazenamento do mês e ano em variáveis */
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            // apresentação dos dados
            Console.WriteLine();
            Console.WriteLine("Name: {0}", worker.Name);
            Console.WriteLine("Department: {0}", worker.Department.Name);
            Console.WriteLine("Informe for {0}: R$ {1}", monthAndYear, worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
