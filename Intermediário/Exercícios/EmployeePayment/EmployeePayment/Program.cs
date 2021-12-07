using System;
using System.Globalization;
using System.Collections.Generic;
using EmployeePayment.Entities;

namespace EmployeePayment {
    class Program {
        static void Main(string[] args) {

            // leitura da repetição de Employees
            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());

            // declaração e instanciação da lista de Employees
            List<Employee> list = new List<Employee>();
            Console.WriteLine();

            /* laço de repetição que lê o nome do funcionário,
             sua quantidade de horas trabalhas e o quanto ele
            recebe por hora e uma pergunta se ele é terceirizado */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Enter {0} data", i + 1);
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // caso ele seja, recebe valor adicional
                if (resp == 'y') {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    // instanciação e armazenamento dos dados na lista, contando o valor adicional
                    list.Add(new OutsourcedEmployee(name, hours, value, addCharge));
                } else {
                    // instanciação e armazenamento dos dados na lista
                    list.Add(new Employee(name, hours, value));
                }

                Console.WriteLine();
            }

            // apresentação dos dados
            Console.WriteLine("Payments: ");
            foreach (Employee emp in list) {
                Console.WriteLine("{0} - $ {1}", emp.Name, emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
