namespace EmployeePayment.Entities {
    // é uma subclasse da Employee
    class OutsourcedEmployee : Employee {

        // propriedade da classe
        public double AdditionalCharge { get; set; }

        // construtor padrão
        public OutsourcedEmployee() { }

        // construtor que recebe as propriedades herdadas e a da classe
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour) {

            AdditionalCharge = additionalCharge;
        }

        // sobreposição do método herdado
        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
