namespace WorkerContracts.Entities {
    class Department {

        // declaração da propriedade da classe
        public string Name { get; set; }

        // construtor padrão
        public Department () {}

        // construtor que recebe o nome como argumento
        public Department (string name) {
            Name = name;
        }
    }
}
