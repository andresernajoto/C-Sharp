using System;
using LearningEnum.Entities.Enums;

namespace LearningEnum.Entities {
    class Order {

        // propriedades do pedido
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        /* override que mostra
        as informações na tela */
        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
