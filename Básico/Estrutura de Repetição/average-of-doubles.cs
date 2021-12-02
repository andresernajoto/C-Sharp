using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("How many doubles will you type? ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 1; i <= number; i++) {
			// Console.Write("Value " + i + ": ");
			string[] value1 = Console.ReadLine().Split(' ');
			double num1 = double.Parse(value1[0]);
			double num2 = double.Parse(value1[1]);
			double num3 = double.Parse(value1[2]);
			
			double average = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
			Console.WriteLine();
			Console.Write(average);
			Console.WriteLine();
		}
	}
}