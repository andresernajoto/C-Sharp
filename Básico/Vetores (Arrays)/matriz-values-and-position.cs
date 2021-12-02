using System;
					
public class Program
{
	public static void Main()
	{
		
		/* as linhas abaixo vão ler o número de
		linhas e colunas, repesctivamente, e
		armazená-las em variáveis separadas */
		string[] num = Console.ReadLine().Split(' ');
		int m = int.Parse(num[0]);
		int n = int.Parse(num[1]);
		
		// declaração e instanciação da matriz
		int[,] mat = new int[m, n];
		
		/* a linha de código abaixo faz a leitura
		das linhas da matriz e as armazena nas
		colunas */
		for (int i = 0; i < m; i++) {
			string[] values = Console.ReadLine().Split(' ');
			
			for (int j = 0; j < n; j++) {
				/* armazenamento do que foi
				digitado em colunas */
				mat[i, j] = int.Parse(values[j]);
			}
		}
		
		/* a linha abaixo faz a leitura do
		valor a ser encontrado na matriz */
		int x = int.Parse(Console.ReadLine());
		
		/* as linhas abaixo mostram as posições
		dos valores da matriz, caso existam */
		for (int i = 0; i < m; i++) {
			for (int j = 0; j < n; j++) {
				/* se o valor de 'x' existir na matriz,
				será apresentada a posição em que ele
				se encontra */
				if (mat[i, j] == x) {
					Console.WriteLine("Position {0},{1}:", i, j);
					
					/* caso a coluna seja maior que zero,
					irá mostrar o valor que fica a esquerda
					de 'x'*/
					if (j > 0) {
						Console.WriteLine("Left: {0}", mat[i, j-1]);
						
					}
					
					/* caso a coluna seja menor que a linha
					menos 1, mostrará o valor que fica a
					direita de 'x' */
					if (j < n - 1) {
						Console.WriteLine("Right: {0}", mat[i, j+1]);
					}
					
					/* caso a linha seja menor que a coluna
					menos 1, mostrará o valor que fica abaixo
					de 'x' */
					if (i < m - 1) {
						Console.WriteLine("Down: {0}", mat[i+1, j]);
					}
					
					/* caso a linha seja maior que zero,
					mostrará o valor que fica acima de
					'x' */
					if (i > 0){
						Console.WriteLine("Up: {0}", mat[i-1, j]);
					}
				}
			}
		}
	}
}