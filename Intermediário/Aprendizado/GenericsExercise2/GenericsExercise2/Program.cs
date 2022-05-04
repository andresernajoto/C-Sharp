using System;

namespace GenericsExercice2 {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe PrintServicee
            PrintServicee<string> printService = new PrintServicee<string>();

            // leitura de quantos valores serão inseridos
            Console.Write("How many values: ");
            int num = int.Parse(Console.ReadLine());

            // loop que lê os valores e armazena na operação AddValue()
            for (int i = 0; i < num; i++) {
                string values = Console.ReadLine();
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
