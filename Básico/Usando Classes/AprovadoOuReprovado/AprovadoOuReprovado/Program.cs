using System;
using System.Globalization;

namespace AprovadoOuReprovado {
    class Program {
        static void Main(string[] args) {

            // Instaciação da classe
            Aluno pessoa = new Aluno();

            /* Leitura do nome do aluno
            e de suas notas */
            Console.Write("Nome do aluno: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 (três) notas do aluno: ");
            pessoa.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Impressão da nota do aluno
            Console.WriteLine("Nota final: " + pessoa.SomaNotas().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            Console.WriteLine();

            /* Condição que chama o método
             de aprovação e caso a pessoa
            tenha a média esperada, mostra
            APROVADO, caso contrário, chama
            o método da nota restante e mostra
            quantos pontos faltaram para a 
            aprovação do aluno*/
            if (pessoa.Aprovacao()) {
                Console.WriteLine("APROVADO!");
            } else {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltaram " + pessoa.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }
        }
    }
}
