using LearningEnum.Entities;
using LearningEnum.Entities.Enums;
using System;

namespace LearningEnum {
    class Program {
        static void Main(string[] args) {

            /* Instanciação de uma variável do tipo Order
             que já recebe seus valores dentro das chaves */
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);

            /* faz a conversão de um tipo
             enumerado para o tipo texto */
            string txt = OrderStatus.PedingPayment.ToString();

            /* faz a conversão de um tipo
             texto para o tipo enumerado */
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
