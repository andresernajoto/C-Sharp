using System;
using System.IO;
using System.Collections.Generic;

namespace InterfaceIComparable {
    class Program {
        static void Main(string[] args) {

            string path = @"D:\.Downloads\Andre\Estudos\Programming\C#\Exercícios\InterfaceIComparable\in.txt";

            /* o bloco try a seguir irá ler o caminho do arquivo
             em seguida criará uma lista aonde serão adicionados
            os nomes da pessoas até que a lista chegue ao final */
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream) {
                        list.Add(sr.ReadLine());
                    }

                    // faz a organização dos dados de uma lista
                    list.Sort();
                    foreach (string str in list) {
                        Console.WriteLine(str);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
