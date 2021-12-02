using System;
					
public class Program
{
	public static void Main()
	{
		
		// declaração das variáveis
		double[] notas = new double[4];
		double soma = 0;
		
		for (int i = 0; i < notas.Length; i++) {
			Console.Write("Digite a nota do " + (i + 1) + "° bimestre: ");
			// leitura da nota
			notas[i] = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Sua nota no " + (i + 1) + "° bimestre é: " + notas[i]);
			Console.WriteLine();
			
			// variável que armazena a soma das notas
			soma += notas[i];
		}
		
		// variável que calcula a média e mostra na tela o resultado
		double media = soma / 4;
		Console.WriteLine("Sua média final é: " + media);
	}
}