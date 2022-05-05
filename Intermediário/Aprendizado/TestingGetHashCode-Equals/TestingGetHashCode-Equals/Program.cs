using System;
using TestingGetHashCode_Equals.Entities;

namespace TestingGetHashCode_Equals {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe Client com os valores
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            // impressão do Equals e GetHashCode
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
