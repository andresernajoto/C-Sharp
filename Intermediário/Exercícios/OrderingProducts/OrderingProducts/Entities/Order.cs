using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using OrderingProducts.Entities.Enums;

namespace OrderingProducts.Entities {
    class Order {

        // declaração das propriedades da classe
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        /* abaixo é feita a leitura dos dados do
         cliente pois ele tem relação com o pedido */
        public Client Client { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();

        // construtor padrão
        public Order() { }

        // construtor com o momento atual, o status do pedido e as informações do cliente
        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // método que adiciona um produto à lista
        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        // método que remove um produto da lista
        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        // método que calcula o valor total do pedido
        public double Total() {
            double sum = 0.0;

            foreach (OrderItem item in Items) {
                sum += item.SubTotal();
            }

            return sum;
        }

        /* método ToString que imprime o valor armzenado
         em outras classes e mostra o resultado final */
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
