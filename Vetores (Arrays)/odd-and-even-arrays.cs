using System;
					
public class Program
{
	public static void Main()
	{
		/* declara��o dos vetores que v�o
		armazenar os dados digitidados e
		classific�-los como par ou �mpar */
		int num;
		int[] vect = new int[20];
		int[] par = new int[20];
		int[] impar = new int[20];
		
		// apresenta��o de informa��o
		Console.WriteLine("Digite os valores do vetor:");
		
		/* leitura dos valores digitidados
		pelo usu�rio e o armazenamento dos
		mesmos dentro do vetor */
		for (int i = 0; i < vect.Length; i++) {
			num = int.Parse(Console.ReadLine());
			vect[i] = num;
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine("Valores digitados:");
		
		/* apresenta��o dos dados
		digitados pelo usu�rio */
		for (int i = 0; i < vect.Length; i++) {
			Console.Write(vect[i] + " ");
		}
		
		/* classifica��o dos dados do
		vetor, podendo ser par ou �mpar*/
		for (int i = 0; i < vect.Length; i++) {
			if (vect[i] % 2 == 0) {
				par[i] = vect[i];
			} else {
				impar[i] = vect[i];
			}
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Valores pares:");
		
		/* apresenta��o dos n�meros
		que s�o do conjunto par */
		for (int i = 0; i < vect.Length; i++) {
			if (par[i] != 0) {
				Console.Write(par[i] + " ");
			}
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Valores �mpares:");
		
		/* apresenta��o dos n�meros
		que s�o do conjunto �mpar */
		for (int i = 0; i < vect.Length; i++) {
			if (impar[i] != 0) {
				Console.Write(impar[i] + " ");
			}
		}
	}
}