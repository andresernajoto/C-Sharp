using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGetHashCode_Equals.Entities {
    class Client {

        // atributos da classe
        public string Name { get; set; }
        public string Email { get; set; }

        // override de Equals para saber se os emails são iguais
        public override bool Equals(object obj) {
            // caso obj não seja do tipo Client,  retornar falso
            if (!(obj is Client)) {
                return false;
            }

            // downcasting
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        // override do GetHashCode para comparar o Email
        public override int GetHashCode() {
            return Email.GetHashCode();
        }
    }
}
