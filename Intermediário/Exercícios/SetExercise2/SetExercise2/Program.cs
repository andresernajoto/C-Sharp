using System;
using System.Collections.Generic;
using SetExercise2.Entities;

namespace SetExercise2 {
    class Program {
        static void Main(string[] args) {

            // instanciação de uma coleção Hash de Students
            HashSet<Students> set = new HashSet<Students>();

            // leitura da quantidade de estudantes no curso A
            Console.Write("How many students for course A: ");
            int num = int.Parse(Console.ReadLine());

            // leitura do ID dos estudantes
            for (int i = 0; i < num; i++) {
                int numOfStudents = int.Parse(Console.ReadLine());
                set.Add(new Students(numOfStudents));
            }

            // leitura da quantidade de estudantes no curso B
            Console.Write("How many students for course B: ");
            num = int.Parse(Console.ReadLine());

            // leitura do ID dos estudantes
            for (int i = 0; i < num; i++) {
                int numOfStudents = int.Parse(Console.ReadLine());
                set.Add(new Students(numOfStudents));
            }

            // leitura da quantidade de estudantes no curso C
            Console.Write("How many students for course C: ");
            num = int.Parse(Console.ReadLine());

            // leitura do ID dos estudantes
            for (int i = 0; i < num; i++) {
                int numOfStudents = int.Parse(Console.ReadLine());
                set.Add(new Students(numOfStudents));
            }

            // apresentação do resultado final
            Console.WriteLine();
            Console.WriteLine("Total of Students: " + set.Count + " students");
        }
    }
}
