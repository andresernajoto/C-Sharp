using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		// leitura do número de repetições
		Console.Write("Digite um número de repetições: ");
		int num = int.Parse(Console.ReadLine());
		
		// apresentação do texto na tela
		Console.WriteLine();
		Console.WriteLine("Digite as alturas abaixo:");
		
		// declaração da soma e do vetor
		double soma = 0.0;
		double[] vect = new double[num];
		
		/* laço de repetição para leitura
		do vetor e armazenamento de sua soma
		na variável SOMA */
		for (int i = 0; i < num; i++) {
			vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			soma += vect[i];
		}
		
		// cálculo da media dos elementos digitados
		double media = soma / num;
		
		// apresentação dos dados
		Console.WriteLine();
		Console.WriteLine("A média entre as alturas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
	}
}