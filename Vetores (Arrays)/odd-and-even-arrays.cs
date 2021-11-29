using System;
					
public class Program
{
	public static void Main()
	{
		/* declaração dos vetores que vão
		armazenar os dados digitidados e
		classificá-los como par ou ímpar */
		int num;
		int[] vect = new int[20];
		int[] par = new int[20];
		int[] impar = new int[20];
		
		// apresentação de informação
		Console.WriteLine("Digite os valores do vetor:");
		
		/* leitura dos valores digitidados
		pelo usuário e o armazenamento dos
		mesmos dentro do vetor */
		for (int i = 0; i < vect.Length; i++) {
			num = int.Parse(Console.ReadLine());
			vect[i] = num;
		}
		
		// apresentação de dados
		Console.WriteLine();
		Console.WriteLine("Valores digitados:");
		
		/* apresentação dos dados
		digitados pelo usuário */
		for (int i = 0; i < vect.Length; i++) {
			Console.Write(vect[i] + " ");
		}
		
		/* classificação dos dados do
		vetor, podendo ser par ou ímpar*/
		for (int i = 0; i < vect.Length; i++) {
			if (vect[i] % 2 == 0) {
				par[i] = vect[i];
			} else {
				impar[i] = vect[i];
			}
		}
		
		// apresentação de dados
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Valores pares:");
		
		/* apresentação dos números
		que são do conjunto par */
		for (int i = 0; i < vect.Length; i++) {
			if (par[i] != 0) {
				Console.Write(par[i] + " ");
			}
		}
		
		// apresentação de dados
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Valores ímpares:");
		
		/* apresentação dos números
		que são do conjunto ímpar */
		for (int i = 0; i < vect.Length; i++) {
			if (impar[i] != 0) {
				Console.Write(impar[i] + " ");
			}
		}
	}
}