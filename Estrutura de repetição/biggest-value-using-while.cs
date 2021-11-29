using System;
					
public class Program
{
	public static void Main()
	{
		/* declaração dos valores e
		leitura do primeiro termo */
		int num = int.Parse(Console.ReadLine());
		int maior = num;
		int i = 0;
		
		/* faz a leitura dos numeros e
		toda vez que ele for maior que
		a variável maior, seu valor
		passa a ser o maior de todos */
		while (i < 4) {
			i++;
			num = int.Parse(Console.ReadLine());
			
			if (num > maior) {
				maior = num;
			}
		}
		
		// apresentação dos dados
		Console.WriteLine();
		Console.WriteLine("O maior valor digitado é: " + maior);
	}
}