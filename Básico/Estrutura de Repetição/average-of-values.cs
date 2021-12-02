using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite um número de repetições: ");
		double valor, soma = 0, media = 0;
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 0; i < num; i++) {
			Console.Write("Digite o " + i + "° valor: ");
			valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			soma += valor;
			Console.WriteLine();
		}
		
		Console.WriteLine();
		media = soma / num;
		Console.WriteLine("A soma entre os valores é: " + media.ToString("F2", CultureInfo.InvariantCulture));
	}
}