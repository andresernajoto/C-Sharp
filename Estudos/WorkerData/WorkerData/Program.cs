using System;
using System.Globalization;
using System.Collections.Generic;

namespace WorkerData {
    class Program {
        static void Main(string[] args) {

            /* leitura da quantidade de funcionários
             que serão lidos no programa */
            Console.Write("How many emplyees will be registered? ");
            int num = int.Parse(Console.ReadLine());

            // declaração e instanciação da lista
            List<Employee> list = new List<Employee>();

            /* laço de repetição que lê os dados
             dos funcionários e guarda eles dentro
            da lista, com o comando Add */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Employee # " + (i + 1) + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                /* comando que adiciona os dados dos
                 funcionários na lista de tipo Employee */
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            // leitura da busca de Id
            Console.Write("Enter the employee id that will have salary increase: ");
            int newId = int.Parse(Console.ReadLine());

            /* instanciação de uma variável do tipo
             da classe que tem como objetivo encontrar
            o Id de um funcionário já existente na lista */
            Employee emp = list.Find(x => x.Id == newId);

            /* caso a variável acima seja diferente de nulo
             e a condição da expressão seja verdadeira, irá
            pedir o aumento salarial do funcionário e aplicar
            o método que faz seu cálculo */
            if (emp != null) {
                Console.Write("Enter the porcentage: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Increasement(porcent);
                /* caso contrário o id fornecido não existe */
            } else {
                Console.WriteLine("This id doesn't exist!");
            }

            // apresentação de dados na tela
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            /* imprime os dados de cada funcionário
             inserido na lista de tipo Employee */
            foreach (Employee worker in list) {
                Console.WriteLine(worker);
            }
        }
    }
}
