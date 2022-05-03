using System;

namespace GenericsExercice {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe PrintServicee
            PrintServicee printService = new PrintServicee();

            // leitura de quantos valores serão inseridos
            Console.Write("How many values: ");
            int num = int.Parse(Console.ReadLine());

            // loop que lê os valores e armazena na operação AddValue()
            for (int i = 0; i < num; i++) {
                int values = int.Parse(Console.ReadLine());
                printService.AddValue(values);
            }

            // apresentação dos dados de maneira formatada
            Console.WriteLine();
            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
