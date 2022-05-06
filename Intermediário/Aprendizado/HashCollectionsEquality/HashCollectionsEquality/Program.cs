using System;
using System.Collections.Generic;
using HashCollectionsEquality.Entities;

namespace HashCollectionsEquality {
    class Program {
        static void Main(string[] args) {

            // instanciação de um HashCode do tipo Product que adiciona dois produtos à coleção
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            // instanciação de um HashCode do tipo Point que adiciona dois pontos à coleção
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            // verifica se o que está na variável 'a' é o mesmo que a instanciação de um 'prod'
            /* será true pois foi feita a implementação do HashCode/Equals
             dentro da classe Product e comparou o valor entre eles */
            // caso não tivesse sido implementada, faria a comparação entre as referências na memória
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            // no caso de structs, ele retorna true, pois os valores são comparados, não a referência
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}
