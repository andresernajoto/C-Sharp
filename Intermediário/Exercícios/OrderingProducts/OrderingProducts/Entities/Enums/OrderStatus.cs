namespace OrderingProducts.Entities.Enums {
    // enumerações do status do pedido
    enum OrderStatus : int {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
