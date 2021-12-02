using System;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Preço: $ ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            /* A linha abaixo faz a chamada do método AdicionarProdutos
            recebendo como parâmetro a variável qtd, que informa a
            quantidade adicionada + a quantidade já existente do estoque */
            p.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados do produto atualizado: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem removidos do estoque: ");
            /* Na linha abaixo a variável é reutilizada pois
            já continha o valor anterior do estoque */
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados do produto atualizado: " + p);

        }
    }
}
