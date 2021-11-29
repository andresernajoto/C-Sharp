using System;

public class Program
{
	public static void Main()
	{
		
		int count = 0;
		
		// leitura do tamanho da matriz quadrada
		int num = int.Parse(Console.ReadLine());
		
		// declara��o e instancia��o da matriz
		int[,] mat = new int[num, num];		
		
		/* o la�o de repeti��o de 'i' vai fazer
		a leitura das linhas da matriz */
		for (int i = 0; i < num; i++) {
			// conforme a linha de c�digo abaixo
			string[] values = Console.ReadLine().Split(' ');
			/* j� o la�o de 'j' vai fazer o
			armazenamento da leitura das linhas
			em colunas */
			for (int j = 0; j < num; j++) {
				// conforme a linha abaixo
				mat[i, j] = int.Parse(values[j]);
			}
		}
		
		// espa�amento e apresenta��o de informa��o
		Console.WriteLine();
		Console.WriteLine("Main diagonal: ");
		
		/* la�o que percorre a matriz encontrando
		seus pontos iguais. Ex.: 0,0; 1,1; 2,2. */
		for (int i = 0; i < num; i++) {
			Console.Write(mat[i, i] + " ");
		}
		
		Console.WriteLine();
		
		/* la�o que percorre toda a matriz e
		conta quantos n�meros negativos fazem
		parte dela */
		for (int i = 0; i < num; i++) {
			for (int j = 0; j < num; j++) {
				if (mat[i, j] < 0) {
					count++;
				}
			}
		}
		
		// apresenta��o de dados
		Console.WriteLine();
		Console.WriteLine("Negative number(s) found: " + count);
	}
}