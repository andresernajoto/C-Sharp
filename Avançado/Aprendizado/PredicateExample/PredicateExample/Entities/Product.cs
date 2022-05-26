using System.Globalization;

namespace PredicateExample.Entities {
    class Product {

        // atributos da classe
        public string Name { get; set; }
        public double Price { get; set; }

        // construtor com os atributos
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // impressão padrão dos valores
        public override string ToString() {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
