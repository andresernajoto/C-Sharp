using System.Globalization;

namespace OrderingProducts.Entities {
    class OrderItem {

        // declaração das propriedades da classe
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        // construtor padrão
        public OrderItem() { }

        // construtor que recebe a quantidade e o preço do pedido
        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        // método que mostra o subtotal dos produtos
        public double SubTotal() {
            return Quantity * Price;
        }

        /* método ToString que imprime os dados
         do produto, como preço e quantidade */
        public override string ToString() {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
