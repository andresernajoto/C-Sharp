using System;
using System.Text;
using System.Collections.Generic;

namespace UsingStringBuilder.Entities {
    class Post {

        // propriedades da classe
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        /* propriedade obtida da classe Comment,
         que tem uma relação "um para muitos"
         com a classe Post, por isso está armazenada
        em uma List e já está instanciada também */
        public List<Comment> Comments { get; set; } = new List<Comment>();

        // construtor padrão
        public Post() { }

        /* construtor que possui o momento atual, 
         um título, conteúdo e likes como argumentos */
        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // adiciona o comentário escrito à lista (feito por padrão)
        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        // remove o comentário escrito da lista (feito por padrão)
        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString() {
            // instanciação do método String Builder
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            
            // laço que percorre os elementos da lista de comentários
            foreach (Comment c in Comments) {
                sb.AppendLine(c.Text);
            }

            // retorna o resultado convertido em ToString()
            return sb.ToString();
        }
    }
}
