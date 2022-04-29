using System;
using InheritanceAndInterface.Model.Entities;
using InheritanceAndInterface.Model.Enums;

namespace InheritanceAndInterface {
    class Program {
        static void Main(string[] args) {

            // instanciação sem construtor das classes que herdam de shape
            // aqui podemos colocar o valor entre chaves {} quando não há construtores
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            // apresentação dos valores por sobrescrição do ToString()
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
