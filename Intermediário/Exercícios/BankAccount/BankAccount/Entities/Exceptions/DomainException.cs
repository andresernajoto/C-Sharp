using System;

namespace BankAccount.Entities.Exceptions {
    // herdado de ApplicationException
    class DomainException : ApplicationException {

        // construtor padrão que herda os atributos de ApplicationException
        public DomainException(string message) : base(message) { }
    }
}
