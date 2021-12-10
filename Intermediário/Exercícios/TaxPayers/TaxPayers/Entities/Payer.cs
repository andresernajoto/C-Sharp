namespace TaxPayers.Entities {
    abstract class Payer {

        // declaração das propriedades da classe
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        // construtor recebendo nome e taxa anual
        public Payer(string name, double annualIncome) {
            Name = name;
            AnnualIncome = annualIncome;
        }

        // método abstrato da taxa paga
        public abstract double Tax();
    }
}
