using System;

namespace Pensionato {
    class Program {
        static void Main(string[] args) {

            // leitura da quantidade de quartos alugados
            Console.Write("How many rooms will be rented? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            /* instanciação do vetor do tipo Estudantes
             recebendo um total de 10 elementos */
            Estudantes[] vect = new Estudantes[10];

            /* laço de repetição que fará a leitura
             do nome e email dos estudantes */
            for (int i = 0; i < num; i++) {
                // apresentação de informações
                Console.WriteLine("Rent #" + (i + 1));

                /* leitura do nome, email e
                quarto alugado pelos estudantes */
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                /* os dados acima serão alocados no
                construtor da classe Estudantes, e 
                serão guardados no vetor[quarto] */
                vect[room] = new Estudantes(name, email);
            }

            // apresentação dos dados na tela
            Console.WriteLine("Busy Rooms:");

            /* para apresentar os dados ordenados,
             teremos um laço de repetição e uma
            condição, que caso o vetor não seja nulo,
            irá mostrar os quartos ocupados pelo estu-
            dantes e seus nomes e emails, respectivamente */
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
