using System;
using System.Globalization;

namespace ContractsData.Entities {
    class Installment {

        // declaração das propriedades
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        // construtor padrão da classe
        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }

        // apresentação dos valores das parcelas correspondente ao mês
        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
