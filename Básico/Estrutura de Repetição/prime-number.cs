using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Type a nubmber: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 1; i <= number; i++) {
			// A linha abaixo representa o cálculo utilizado
			// para saber se um número é primo ou não.
			if (number % i == 0) {
				Console.WriteLine(i);
			} 
		}
	}
}