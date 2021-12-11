using System;

namespace TryCatch {
    class Program {
        static void Main(string[] args) {

            // o bloco try tentará rodar o programa
            try {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine(result);
                // se houver exceções, os blocos catchs abaixo irão entrar em cena
            } catch (DivideByZeroException) {
                Console.WriteLine();
                Console.WriteLine("Division to zero is not allowed!");
                // o 'e' abaixo é um apelido da exceção para chamar seus métodos
            }
            catch (FormatException e) {
                Console.WriteLine();
                Console.WriteLine("Format error! {0}", e.Message);
            }
        }
    }
}
