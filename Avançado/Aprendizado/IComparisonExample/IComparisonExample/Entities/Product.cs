using System.Globalization;

namespace IComparisonExample.Entities {
    class Product {

        // declarçaão dos atributos
        public string Name { get; set; }
        public double Price { get; set; }

        // construtor recebendo os atributos
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // sobreescritura do ToString()
        public override string ToString() {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
