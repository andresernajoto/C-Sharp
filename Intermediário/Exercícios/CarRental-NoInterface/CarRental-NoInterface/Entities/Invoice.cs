using System.Globalization;

namespace CarRental_NoInterface.Entities {
    class Invoice {

        // declaração das propriedades
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        // construtor que recebe as propriedades como argumento
        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        // propriedade cujo o seu get é o cálculo das propriedades acima
        public double TotalPayment {
            get { return BasicPayment + Tax; }
        }

        // override que apresenta os dados do Invoice
        public override string ToString() {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
