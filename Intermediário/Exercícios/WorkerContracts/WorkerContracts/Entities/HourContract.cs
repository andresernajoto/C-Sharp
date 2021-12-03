using System;

namespace WorkerContracts.Entities {
    class HourContract {

        // declaração das propriedades da classe
        public DateTime Date{ get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        // construtor padrão
        public HourContract() { }

        // construtor que recebe uma data, valor por hora e horas do contrato
        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // método que calcula o valor total do salário
        public double TotalValue() {
            return ValuePerHour * Hours;
        }

    }
}
