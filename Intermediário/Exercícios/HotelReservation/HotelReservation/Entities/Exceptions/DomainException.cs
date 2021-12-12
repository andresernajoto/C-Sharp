using System;

namespace HotelReservation.Entities.Exceptions {
    // herda de ApplicationException
    class DomainException : ApplicationException {

        // construtor que recebe uma exceção customizada
        public DomainException(string message) : base(message) { }
    }
}
