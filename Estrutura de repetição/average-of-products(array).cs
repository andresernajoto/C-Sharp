using System;
using System.Globalization;

public class Program
{
	public static void Main()
	{
		// leitura do número de repetições
		Console.Write("Digite o número de repetições: ");
		int num = int.Parse(Console.ReadLine());
		
		/* declaração da variável soma,
		array com os nomes dos produtos
		e um com os preços dos produtos */
		double soma = 0;
		string[] vectNomes = new string[num];
		double[] vectPrecos = new double[num];
		
		// apresentação das informações na tela
		Console.WriteLine();
		Console.WriteLine("Digite o nome do produto e o preço, respectivamente, abaixo:");
		
		/* laço de repetição para leitura do
		nome e preço do produto, e a soma entre
		os preços digitados, respectivamente */
		for (int i = 0; i < num; i++) {
			vectNomes[i] = Console.ReadLine();
			vectPrecos[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			soma += vectPrecos[i];
		}
		
		// armazenamento da soma do que foi digitado
		double media = soma / num;
		
		// apresentação dos dados na tela
		Console.WriteLine();
		Console.WriteLine("A média entre os preços é: R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
	}
}