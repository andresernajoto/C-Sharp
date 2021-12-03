using System;
using System.Globalization;
using OrderingProducts.Entities;
using OrderingProducts.Entities.Enums;

namespace OrderingProducts {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter the client data:");

            /* leitura do nome, email e
             data de nascimento do cliente */
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            /* instanciação da classe Client e
             armazemento dos dados digitados acima */
            Client client = new Client(name, email, birthDate);

            // leitura do status do pedido
            Console.WriteLine();
            Console.WriteLine("Enter the order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            // instancição do pedido e armazenamento de seus dados
            Order order = new Order(DateTime.Now, os, client);

            // leitura do número de repetições
            Console.WriteLine();
            Console.Write("How many items to this order: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            /* laço de repetição que lê o nome do produto,
             seu preço e a quantidade comprada. Em seguida
            armazena essas informações na classe Product e
            também na classe OrderItem, que recebe o Product
            como valor final. */
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Enter the {0} item data", i + 1);
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product prod = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice, prod);

                // Por fim, o order abaixo armazena os dados acima
                order.AddItem(orderItem);
            }

            // apresentação dos dados
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}
