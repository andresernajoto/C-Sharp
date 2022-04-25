namespace CarRental_NoInterface.Entities {
    class Vehicle {
        // declaração da propriedade da classe
        public string Model { get; set; }

        // construtor que recebe o modelo como argumento
        public Vehicle(string model) {
            Model = model;
        }
    }
}
