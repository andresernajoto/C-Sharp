using System;

namespace OrderingProducts.Entities {
    class Client {

        // declaração das propriedades da classe
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        // construtor padrão
        public Client() { }

        // construtor que recebe o nome, email e data de nascimento do cliente
        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        /* método ToString que imprime
         os dados do nosso Cliente */
        public override string ToString() {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
