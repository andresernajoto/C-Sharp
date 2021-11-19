using System.Globalization;

namespace Estoque_V2._0 {
    class Produto {

        /* declaração dos atributos privados
        usando o nome de convenção da linguagem*/
        private string _nome;
        private double _preco;
        private int _quantidade;


        // construtor padrão (sem atributos)
        public Produto() {

        }

        // construtor com os atributos (nome, preco e quantidade)
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // construtor com os atributos (nome e preco)
        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        /* o método abaixo permite que o dev
         consiga acessar o atributo do nome,
        mesmo ele sendo privado */
        public string GetNome() {
            return _nome;
        }

        /* o método abaixo permite que o dev
         possa alterar o atributo do nome,
        mesmo ele sendo privado */
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        /* o método abaixo permite que o dev
         consiga acessar o atributo do preço,
        mesmo ele sendo privado */
        public double GetPreco() {
            return _preco;
        }

        /* o método abaixo permite que o dev
         consiga acessar o atributo da quantidade,
        mesmo ela sendo privado */
        public int GetQuantidade() {
            return _quantidade;
        }

        /* método que retorna o valor total em estoque
        multiplicando o preco pela quantidade*/
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        /* método que adiciona
         novos produtos ao estoque*/
        public double AdicionarProdutos(int qtd) {
            return _quantidade += qtd;
        }

        /* método que remove os
         produtos do estoque*/
        public double RemoverProdutos(int qtd) {
            return _quantidade -= qtd;
        }

        /* override do método ToString para
         mostrar na tela os valores que precisam
        ser apresentados, sem precisar ficar
        repetindo a mesma linha de código*/
        public override string ToString() {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
