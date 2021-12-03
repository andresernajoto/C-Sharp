using WorkerContracts.Entities.Enums;
using System.Collections.Generic;

namespace WorkerContracts.Entities {
    class Worker {

        // declaração das propriedades da classe
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        // associação entre a classe Department e Worker
        public Department Department { get; set; }
        /* associação entre a classe HourContract e Worker.
         Pelo fato da relação entre o Worker e o HourContract
        ser de "tem-vários", os valores do HourContract serão
        armazenados dentro de uma List */
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // construtor padrão
        public Worker() { }

        // construtor que recebe o nome, nível e salário base do trabalhador
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        /* método que adiciona o contrato do
         trabalhador à lista de Contratos */
        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        /* método que remove o contrato do
         trabalhador da lista de Contratos */
        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        /* método que percorre cada contrato da
         list Contracts e aplica uma condição se o
        mês e ano do contrato for ok, somando o valor
        do salário base do funcionário com o valor total
        dos contratos de determinado mês */
        public double Income(int year, int month) {
            double sum = BaseSalary;
           
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
