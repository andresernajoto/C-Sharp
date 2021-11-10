using System;

namespace ReadingData {
    class Program {
        static void Main(string[] args) {

            Data fPerson, sPerson;

            fPerson = new Data();
            sPerson = new Data();

            Console.WriteLine("Data from the first person: ");
            Console.Write("Name: ");
            fPerson.name = Console.ReadLine();
            Console.Write("Age: ");
            fPerson.age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Data from the second person: ");
            Console.Write("Name: ");
            sPerson.name = Console.ReadLine();
            Console.Write("Age: ");
            sPerson.age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (fPerson.age > sPerson.age) {
                Console.WriteLine("Older person: " + fPerson.name);
            } else {
                Console.WriteLine("Older person: " + sPerson.name);
            }

        }
    }
}
