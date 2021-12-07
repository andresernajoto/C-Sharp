namespace EmployeePayment.Entities {
    class Employee {

        // declaração das propriedades da classe
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        // construtor padrão
        public Employee() { }

        // construtor que recebe as propriedades
        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // método que calcula o valor do pagamento
        public virtual double Payment() {
            return Hours * ValuePerHour;
        }
    }
}
