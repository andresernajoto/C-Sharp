using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.Write("Put the first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Put the second number: ");
		int num2 = int.Parse(Console.ReadLine());
		int count = num1;
		int sum = 0;
		
		Console.WriteLine();
		Console.WriteLine("The numbers between " + num1 + " and " + num2 + " are: ");
		
		while (count >= num1 && count < num2 - 1) {
			count += 1; 
			sum += count;
			Console.WriteLine();
			Console.WriteLine(count);
		}
		
		Console.WriteLine();
		Console.WriteLine("Total = " + sum);
	}
}
