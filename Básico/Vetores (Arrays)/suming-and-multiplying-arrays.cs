using System;
					
public class Program
{
	public static void Main()
	{
		// declaração das variáveis
		int[] vect = new int[5];
		int sum = 0, mult = 1;
		
		/* laço que lê os números digitados
		e faz a soma e multiplicação deles*/
		for (int i = 0; i < vect.Length; i++) {
			vect[i] = int.Parse(Console.ReadLine());
			sum += vect[i];
			mult *= vect[i];
		}
		
		// apresentação de dados
		Console.WriteLine();
		Console.WriteLine("The typed values are: ");
		
		/* laço que apresenta os
		valores digitados no vetor */
		for (int i = 0; i < vect.Length; i++) {
			Console.Write(vect[i] + " ");
		}
		
		// apresentação de dados
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("The sum of the values is: " + sum);
		Console.WriteLine("The multiplication of the values is: " + mult);
	}
}