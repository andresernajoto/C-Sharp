using System;
using UsingStringBuilder.Entities;

namespace UsingStringBuilder {
    class Program {
        static void Main(string[] args) {


            // instanciação de dois objetos da classe Comment
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            /* instanciação do objeto Post recebendo os parâmetros: 
             - DateTime | Title | Content | Likes */
            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);

            // adiciona o comentário instanciado ao post
            p1.AddComment(c1);
            p1.AddComment(c2);

            // instanciação de dois objetos da classe Comment
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            /* instanciação do objeto Post recebendo os parâmetros: 
             - DateTime | Title | Content | Likes */
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);

            // adiciona o comentário instanciado ao post
            p2.AddComment(c3);
            p2.AddComment(c4);

            // apresentação dos dados
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
