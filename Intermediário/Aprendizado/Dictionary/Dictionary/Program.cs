using System;
using System.Collections.Generic;

namespace Dictionary {
    class Program {
        static void Main(string[] args) {

            // instanciação de um dicionário
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // adição de chaves e valores ao dicionário
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "87337388";

            // impressão das chaves email e phone
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);
            Console.WriteLine();

            // remoção do email e condição que impreme uma mensagem se a chave não existir
            cookies.Remove("email");
            if (cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            } else {
                Console.WriteLine("There is no email key!");
            }

            // apresenta o tamanho do dicionário
            Console.WriteLine();
            Console.WriteLine("Size of cookies: " + cookies.Count);
            Console.WriteLine();

            // para imprimir um dicionário usamos o foreach
            // Detalhe: é usado um KeyValuePair para impressão
            Console.WriteLine("All Cookies:");
            foreach (KeyValuePair<string, string> item in cookies) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
