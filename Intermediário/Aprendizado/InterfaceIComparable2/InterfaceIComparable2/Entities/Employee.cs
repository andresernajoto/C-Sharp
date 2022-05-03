using System;
using System.Globalization;

namespace InterfaceIComparable2.Entities {
    class Employee : IComparable {

        // declaração dos atributos
        public string Name { get; set; }
        public double Salary { get; set; }

        // instanciação do CultureInfo para encurtar sua chamada
        CultureInfo CI = CultureInfo.InvariantCulture;

        // construtor em formato de vetor
        // irá armazenar o nome na posiçãio 0 e salário na posição 1
        public Employee(string csvEmployee) {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CI);
        }

        // override do ToString() para o que será impresso na tela
        public override string ToString() {
            return Name
                + ", "
                + Salary.ToString("F2", CI);
        }

        // faz a comparação entre os nomes dos funcionários
        public int CompareTo(object obj) {
            if (!(obj is Employee)) {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
