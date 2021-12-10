namespace TaxPayers.Entities {
    // herdado de Payer
    class PhysicalPerson : Payer {

        // declaração da propriedade da classe
        public double HealthExpenses { get; set; }

        // construtor que recebe os dados de Payer mais sua propriedade
        public PhysicalPerson(string name, double annualIncome, double healthExpenses)
            : base(name, annualIncome) {
            HealthExpenses = healthExpenses;
        }

        // override do método abstrato
        public override double Tax() {
            if (AnnualIncome < 20000.0 && HealthExpenses > 0) {
                return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
            }
            else {
                return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
            }
        }
    }
}
