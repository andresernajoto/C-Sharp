// using System;
using System.Globalization;

namespace Estoque {
    class Produto {

        // Declaração dos atributos do exercício
        public string Nome;
        public double Preco;
        public int Quantidade;

        /* O método abaixo retorna
        o valor total do estoque
        multiplicando o preco
        pela quantidade */
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        /* Quando temos um tipo void,
        é porquê não há o retorno
        de uma saída no programa */
        // Método que adiciona produtos ao estoque
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        // Método que remove produtos ao estoque
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        /* No método abaixo foi feita
        uma sobreposição de método
        para que a impressão do texto
        apareça de forma mais organizada */
        public override string ToString() {
            /* para melhor organização do código,
            foi feita uma quebra na linha
            (não altera o programa) para
            melhor separação do que vai
            ser mostrado na tela */
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
