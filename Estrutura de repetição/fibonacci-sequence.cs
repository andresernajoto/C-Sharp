using System;
					
public class Program
{
	public static void Main()
	{
		
		// declaração das variáveis
		int proximo = 0, anterior = 0;
		
		// leitura do término que será lido
		Console.Write("Digite o termo da sequência: ");
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		/* laço de repetição que faz
		a soma do próximo - anterior
		e o anterior recebendo o
		próximo termo da sequência menos
		ele mesmo */
		for (int i = 0; i < num; i++) {
			Console.WriteLine(proximo);
			proximo += anterior;
			anterior = proximo - anterior;
			
			/* se o próximo for 0, então
			ele receberá 1 e começará a
			apresentar os termos da sequência */
			if (proximo == 0) {
				proximo += 1;
			}
		}
	}
}