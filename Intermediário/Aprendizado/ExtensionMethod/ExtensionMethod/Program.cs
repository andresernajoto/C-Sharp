using System;

namespace ExtensionMethod {
    class Program {
        static void Main(string[] args) {

            // instanciação um horário e apresentação do tempo decorrido
            DateTime dt = new DateTime(2022, 05, 10, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
