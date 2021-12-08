using System.Globalization;

namespace ProductTag.Entities {
    class Product {

        // declaração das propriedades da classe
        public string Name { get; set; }
        public double Price { get; set; }

        // construtor padrão
        public Product() { }

        // construtor que recebe o nome e preço do produto
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // método que apresenta o resultado
        public virtual string PriceTag() {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
