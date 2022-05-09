namespace SetExercise2.Entities {
    class Students {
        
        // atributo da classe
        public int StudentsID { get; set; }
        
        // construtor com o atributo
        public Students(int studentsID) {
            StudentsID = studentsID; 
        }

        // adquire o HashCode do ID do estudante
        public override int GetHashCode() {
            return StudentsID.GetHashCode();
        }

        // Obtém um booleano para o ID do estudante
        public override bool Equals(object obj) {
            if (!(obj is Students)) {
                return false;
            }

            Students other = obj as Students;
            return StudentsID.Equals(other.StudentsID);
        }
    }
}
