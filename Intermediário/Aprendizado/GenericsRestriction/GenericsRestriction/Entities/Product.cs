using System;
using System.Globalization;

namespace GenericsRestriction.Entities {
    class Product : IComparable {
        // atributos da classe
        public string Name { get; set; }
        public double Price { get; set; }

        // construtor com os atributos da classe
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // override do ToString() para formatação do que será impresso
        public override string ToString() {
            return Name + ", R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        // implementação da interface IComparable
        public int CompareTo(object obj) {
            // lançamento de excecão se o argumento não for do tipo Product
            if (!(obj is Product)) {
                throw new ArgumentException("Comparing error: Argument is not a Product");
            }

            // Atribui o obj como Product e compara o preço entre eles
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
