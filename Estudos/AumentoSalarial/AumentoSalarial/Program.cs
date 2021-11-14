using System;
using System.Globalization;

namespace AumentoSalarial {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe
            Funcionario pessoa = new Funcionario();

            /* leitura do nome, salário bruto
            e imposto do Funcionario */
            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // retorno dos valores digitados
            Console.WriteLine("Funcionário: " + pessoa + pessoa.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // leitura do aumento do salário
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            pessoa.AumentarSalario(porcent);

            // retorno do salário atualizado
            Console.WriteLine("Funcionário: " + pessoa + pessoa.AumentarSalario(porcent).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
