using System.Globalization;

namespace ProductTag.Entities {
    // herdado da Product
    class ImportedProduct : Product {

        // declaração das propriedades da classe
        public double CustomsFee { get; set; }

        // construtor padrão
        public ImportedProduct() { }

        /* construtor que recebe os dados de 
         Product e inclui o Customs Fee */
        public ImportedProduct(string name, double price, double customsFee)
            : base (name, price) {

            CustomsFee = customsFee;
        }

        // método que calcula o preço total do produto
        public double TotalPrice() {
            return Price + CustomsFee;
        }

        // override do PriceTag
        public override string PriceTag() {
            return Name
                + "$ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs Fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
