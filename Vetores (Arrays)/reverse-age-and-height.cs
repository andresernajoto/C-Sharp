using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		
		/* declaração das idades e altura,
		e o vetor que vão guardar elas */
		int idade;
		double altura;
		int[] vectIdade = new int[5];
		double[] vectAltura = new double[5];
		
		/* laço que faz a leitura da idade
		e altura e os armazena em seus
		devidos vetores */
		for (int i = 0; i < 5; i++) {
			Console.Write("Digite sua idade: ");
			idade = int.Parse(Console.ReadLine());
			Console.Write("Digite sua altura: ");
			altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine();
			
			vectIdade[i] = idade;
			vectAltura[i] = altura;
		}
		
		// coloca as idades na ordem reversa
		Array.Reverse(vectIdade);
		
		/* mostra as idades na ordem reversa */
		Console.WriteLine("Idade na ordem reversa: ");
		foreach (int i in vectIdade) {
			Console.Write(i + " ");
		}
		
		// coloca as alturas na ordem reversa
		Array.Reverse(vectAltura);
		Console.WriteLine();
		
		/* mostra as alturas na ordem reversa */
		Console.WriteLine("Altura na ordem reversa: ");
		foreach (double i in vectAltura) {
			Console.Write(i + " ");
		}
	}
}