using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		/* declaração do vetor 
			que possui 30 elementos */
			double[] vect = new double[31];

			/* laço de repetição com o objetivo
			 de mostrar o dia e ler o valor
			digitado pelo usuário */
			for (int i = 1; i < vect.Length; i++) {
				Console.WriteLine("dia: " + i);
				Console.Write("valor: ");
				vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.WriteLine();
			}

			/* laço de repetição com o objetivo
			 de mostrar os valores na tela */
			for (int i = 1; i < vect.Length; i++) {
				Console.WriteLine("dia: " + i);
				Console.WriteLine("valor: " + vect[i].ToString("F4", CultureInfo.InvariantCulture));
				Console.WriteLine();
			}
	}
}