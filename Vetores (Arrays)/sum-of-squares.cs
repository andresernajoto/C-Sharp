using System;
					
public class Program
{
	public static void Main()
	{
		// declara��o de vari�veis
		int[] vect = new int[4];
		int quad, sumQuad = 0;
		
		Console.WriteLine("Digite os valores:");
		
		/* la�o que faz a leitura dos
		valores e armazena a soma do
		quadrado dos valores digitados */
		for (int i = 0; i < vect.Length; i++) {
			vect[i] = int.Parse(Console.ReadLine());
			
			// armazena o quadrado do valor digitado
			quad = vect[i] * vect[i];
			
			// faz a soma entre os quadrados
			sumQuad += quad;
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine("Soma do quadrado dos valores digitados: {0}", sumQuad);
	}
}