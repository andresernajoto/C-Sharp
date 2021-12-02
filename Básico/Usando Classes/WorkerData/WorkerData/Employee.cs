using System.Globalization;

namespace WorkerData {
    class Employee {

        /* declaração das properties*/
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        // construtor vazio
        public Employee() {

        }

        /* construtor que recebe o id,
         nome e salário do funcionário */
        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        /* método que calcula a porcentagem
         de aumento do salário do funcionário */
        public double Increasement(double increase) {
            return Salary += Salary * (increase / 100.0) ;
        }

        /* método ToString para imprimir os
         valores na tela já formatados */
        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
