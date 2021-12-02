using System;
using System.Globalization;

namespace EmployeeSalary {
    class Program {
        static void Main(string[] args) {

            EmployeeData fEmployee, sEmployee;
            fEmployee = new EmployeeData();
            sEmployee = new EmployeeData();

            Console.WriteLine("Data from the first employee: ");
            Console.Write("Name: ");
            fEmployee.name = Console.ReadLine();
            Console.Write("Salary: ");
            fEmployee.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Data from the second employee: ");
            Console.Write("Name: ");
            sEmployee.name = Console.ReadLine();
            Console.Write("Salary: ");
            sEmployee.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double averageSalary = (fEmployee.salary + sEmployee.salary) / 2;
            Console.WriteLine("Average of salary: R$ " + averageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
