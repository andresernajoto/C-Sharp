using System;
using System.Globalization;

namespace Estoque_V2._0 {
    class Program {
        static void Main(string[] args) {

            /* leitura do nome do produto,
             preco e quantidade, respectivamente*/
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            /* instanciação do construtor
             com seus atributos recebidos*/
            Produto p = new Produto(nome, preco, quantidade);

            /* linha de separação e
             visualização do resultado */
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            /* quantidade de produtos a
             ser adicionada ao estoque*/
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            /* linha de separação e
             visualização do resultado */
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            /* quantidade de produtos a
             ser removida do estoque*/
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            /* linha de separação e
             visualização do resultado */
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

        }
    }
}
