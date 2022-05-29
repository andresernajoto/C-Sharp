using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using LinqExercise2.Entities;

namespace LinqExercise2 {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("Enter salary: ");
                double typedSalary = double.Parse(Console.ReadLine());

                var listedEmails = list
                    .Where(e => e.Salary > 2000.00)
                    .OrderBy(e => e.Email)
                    .Select(e => e.Email);

                var sum = list
                    .Where(e => e.Name[0] == 'M')
                    .Sum(e => e.Salary);

                Console.WriteLine("\nEmail of people whose salary is more than R$ 2000.00:");
                foreach (string emails in listedEmails) {
                    Console.WriteLine(emails);
                }
                Console.WriteLine("\nSum of salary of people whose name starts with 'M': R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
