using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("How many integers numbers do you will type? ");
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine();
		int sum = 0;
		
		for (int i = 1; i <= num; i++) {
			Console.Write("Value #" + i + ": ");
			int values = int.Parse(Console.ReadLine());
			sum += values;
		} 
		Console.WriteLine();
		Console.WriteLine("Sum of the numbers: " + sum);
	}
}