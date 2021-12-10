namespace TaxPayers.Entities {
    // herdado de Payer
    class LegalEntity : Payer {

        // declaração da propriedade da classe
        public int NumOfEmployees { get; set; }

        // construtor que recebe os dados de Payer mais sua propriedade
        public LegalEntity(string name, double annualIncome, int numOfEmployees)
            : base(name, annualIncome) {
            NumOfEmployees = numOfEmployees;
        }

        // override do método abstrato
        public override double Tax() {
            if (NumOfEmployees > 10) {
                return AnnualIncome * 0.14;
            } else {
                return AnnualIncome * 0.16;
            }
        }
    }
}
