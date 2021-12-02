using System;
					
public class Program
{
	public static void Main()
	{
		
		// declaração de variáveis
		double nota;
		double media = 0;
		double[] vect = new double[4];
		
		/* laço que faz a contagem
		da quantidade de alunos */
		for (int i = 0; i < 10; i++) {
			Console.WriteLine("=======");
			Console.WriteLine("Aluno {0}", i + 1);
			Console.WriteLine("=======");
			Console.WriteLine();
			
			/* laço que lê as notas dos alunos
			e as armazena dentro da média */
			for (int j = 0; j < vect.Length; j++) {
				Console.Write("Nota {0}: ", j + 1);
				nota = double.Parse(Console.ReadLine());
				
				// soma das notas do aluno
				media += nota;
			}	
			
			/* as linhas abaixo fazem a divisão
			da nota por 4 e zeram a média para
			ser feito o cálculo do próximo aluno */
			vect[i] = media / vect.Length;
			media = 0;
			
			// pula linhas
			Console.WriteLine();
			Console.WriteLine("---------");
			Console.WriteLine();
		}
		
		// apresentação das médias
		Console.WriteLine("Média dos alunos:");
		Console.WriteLine();
		
		/* laço que aplica uma condição que mostra
		as notas do aluno e diz se foi acima ou
		abaixo da média da escola */
		for (int i = 0; i < 10; i++) {
			if (vect[i] >= 7.0 && vect[i] <= 10.0) {
				Console.WriteLine("Aluno {0} obteve nota: {1}", (i + 1), vect[i]);
			} else {
				Console.WriteLine("Aluno {0} obteve nota: {1} (ABAIXO DA MÉDIA)", (i + 1), vect[i]);
			}
		}
	}
}