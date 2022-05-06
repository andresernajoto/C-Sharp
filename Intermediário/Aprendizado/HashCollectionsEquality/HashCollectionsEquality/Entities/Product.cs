using System;
using System.Collections.Generic;
using System.Text;

namespace HashCollectionsEquality.Entities {
    class Product {

        //declaração dos atributos
        public string Name { get; set; }
        public double Price { get; set; }

        // construtor recebendo os atributos
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // retorna o HashCode do nome e preço de um produto
        public override int GetHashCode() {
            return Name.GetHashCode() + Price.GetHashCode();
        }
        
        // override de Equals para comparar o nome e preço de um produto
        public override bool Equals(object obj) {
            if (!(obj is Product)) {
                return false;
            }

            // o other precisa ter o mesmo nome e preço dos atributos da classe para serem iguais
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
