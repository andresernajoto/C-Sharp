using System;

namespace CarRental_NoInterface.Entities {
    class CarRental {

        // propriedades da classe
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        // Associação das classes dentro de Entities
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        // construtor que recebe as propriedades acima
        // Detalhe: o Invoice começa como nulo, por isso não está incluso abaixo
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle) {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
