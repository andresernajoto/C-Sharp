using System;
using ContractsData.Entities;

namespace ContractsData.Services {
    class ContractService {

        // declaração da variável da interface
        private IOnlinePaymentService _onlinePaymentService;

        // construtor que carrega em si a interface
        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {
            // a variavel a seguir armazena o valor total do contrato dividido pela qtd de parcela
            double basicQuota = contract.TotalValue / months;

            /* o código abaixo acrescenta o i em meses e
             atualiza o valor da variavel basicQuota adicionando
            o valor de juros simples e depois o valor da taxa padrão */
            for (int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);

                // após executado o código acima, a parcela é adicionada à lista de parcelas
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
