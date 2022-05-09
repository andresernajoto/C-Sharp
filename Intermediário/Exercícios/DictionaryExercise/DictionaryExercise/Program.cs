using System;
using System.IO;
using System.Collections.Generic;

namespace DictionaryExercise {
    class Program {
        static void Main(string[] args) {

            // instanciação de um dictionary
            Dictionary<string, int> candidate = new Dictionary<string, int>();

            // leitura do caminho do arquivo
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            // abertura do arquivo e leitura de suas linhas
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream) {
                        // divisão do conteúdo da linha em nome e qtd. de votos
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int voteQuantity = int.Parse(line[1]);

                        /* se o dictionary contém uma chave NAME,
                         some os votos daquela chave. Caso contrário,
                        crie uma chave recebendo sua quantidade de votos */
                        if (candidate.ContainsKey(name)) {
                            candidate[name] += voteQuantity;
                        } else {
                            candidate[name] = voteQuantity;
                        }
                    }
                }
                // apresentação da exceção
            } catch (IOException e) {
                Console.WriteLine("An error ocurred: " + e.Message);
            }

            // impressão dos valores do dictionary
            Console.WriteLine();
            foreach (KeyValuePair<string, int> item in candidate) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
