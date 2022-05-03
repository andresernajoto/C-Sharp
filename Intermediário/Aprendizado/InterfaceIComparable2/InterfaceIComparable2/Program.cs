using System;
using System.IO;
using System.Collections.Generic;
using InterfaceIComparable2.Entities;

namespace InterfaceIComparable2 {
    class Program {
        static void Main(string[] args) {

            string path = @"D:\.Downloads\Andre\Estudos\Programming\C#\Exercícios\InterfaceIComparable2\in.txt";

            /* o bloco try a seguir irá ler o caminho do arquivo
             em seguida criará uma lista aonde serão adicionados
            os nomes da pessoas até que a lista chegue ao final */
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    // faz a organização dos dados de uma lista
                    list.Sort();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
