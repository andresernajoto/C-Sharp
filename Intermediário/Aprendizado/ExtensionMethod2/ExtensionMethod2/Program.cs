﻿using System;

namespace ExtensionMethod2 {
    class Program {
        static void Main(string[] args) {

            // string recebendo um texto e aplicando o método de extensão
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
