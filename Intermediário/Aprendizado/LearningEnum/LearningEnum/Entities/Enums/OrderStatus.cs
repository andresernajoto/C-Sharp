namespace LearningEnum.Entities.Enums {
    enum OrderStatus : int {

        // ciclo de vida do pedido
        PedingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
