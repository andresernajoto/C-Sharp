using System;
					
public class Program
{
	public static void Main()
	{
		// declara��o das vari�veis
		int[] vect = new int[5];
		int sum = 0, mult = 1;
		
		/* la�o que l� os n�meros digitados
		e faz a soma e multiplica��o deles*/
		for (int i = 0; i < vect.Length; i++) {
			vect[i] = int.Parse(Console.ReadLine());
			sum += vect[i];
			mult *= vect[i];
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine("The typed values are: ");
		
		/* la�o que apresenta os
		valores digitados no vetor */
		for (int i = 0; i < vect.Length; i++) {
			Console.Write(vect[i] + " ");
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("The sum of the values is: " + sum);
		Console.WriteLine("The multiplication of the values is: " + mult);
	}
}