using System;
using System.IO;
using System.Collections.Generic;
using SetExercise.Entities;

namespace SetExercise {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            // leitura do caminho do arquivo
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            // abre o arquivo, lê e imprime suas linhas
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        // leitura da linha e divisão do conteúdo em duas variáveis
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        // adição dos dados do usuário ao conjunto
                        set.Add(new LogRecord(username, instant));
                    }

                    // inserção dos valores
                    Console.WriteLine();
                    Console.WriteLine("Total users: " + set.Count + " users founded!");
                }
                // caso haja alguma exceção, irá apresentá-la
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
