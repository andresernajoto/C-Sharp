namespace UsingStringBuilder.Entities {
    class Comment {

        // propriedade da classe
        public string Text { get; set; }

        // construtor padrão
        public Comment() { }

        // construtor que recebe um texto como argumento
        public Comment(string text) {
            Text = text;
        }
    }
}
