using System;
					
public class Program
{
	public static void Main()
	{
		
		// declara��o de vari�veis
		double nota;
		double media = 0;
		double[] vect = new double[4];
		
		/* la�o que faz a contagem
		da quantidade de alunos */
		for (int i = 0; i < 10; i++) {
			Console.WriteLine("=======");
			Console.WriteLine("Aluno {0}", i + 1);
			Console.WriteLine("=======");
			Console.WriteLine();
			
			/* la�o que l� as notas dos alunos
			e as armazena dentro da m�dia */
			for (int j = 0; j < vect.Length; j++) {
				Console.Write("Nota {0}: ", j + 1);
				nota = double.Parse(Console.ReadLine());
				
				// soma das notas do aluno
				media += nota;
			}	
			
			/* as linhas abaixo fazem a divis�o
			da nota por 4 e zeram a m�dia para
			ser feito o c�lculo do pr�ximo aluno */
			vect[i] = media / vect.Length;
			media = 0;
			
			// pula linhas
			Console.WriteLine();
			Console.WriteLine("---------");
			Console.WriteLine();
		}
		
		// apresenta��o das m�dias
		Console.WriteLine("M�dia dos alunos:");
		Console.WriteLine();
		
		/* la�o que aplica uma condi��o que mostra
		as notas do aluno e diz se foi acima ou
		abaixo da m�dia da escola */
		for (int i = 0; i < 10; i++) {
			if (vect[i] >= 7.0 && vect[i] <= 10.0) {
				Console.WriteLine("Aluno {0} obteve nota: {1}", (i + 1), vect[i]);
			} else {
				Console.WriteLine("Aluno {0} obteve nota: {1} (ABAIXO DA M�DIA)", (i + 1), vect[i]);
			}
		}
	}
}