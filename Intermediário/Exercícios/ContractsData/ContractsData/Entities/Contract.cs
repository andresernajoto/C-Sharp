using System;
using System.Collections.Generic;

namespace ContractsData.Entities {
    class Contract {

        // declaração das propriedades
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        // declaração de uma lista do tipo installments
        // irá armazenar as parcelas de pagamento
        public List<Installment> Installments { get; set; }

        // construtor padrão da classe
        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        // método que irá adicionar o valor das parcelas
        public void AddInstallments(Installment installment) {
            Installments.Add(installment);
        }
    }
}
