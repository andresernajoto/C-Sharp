using System;
					
public class Program
{
	public static void Main()
	{
		int count = 0;
		int num = 0;
		int sum = 0;
		int average = 1;
		Console.WriteLine();
		
		while (count < 5) {
			count += 1;
			Console.Write("Put a number: ");
			num = int.Parse(Console.ReadLine());
			Console.WriteLine();
			sum += num;
		}
		
		average = sum / 5;
		Console.WriteLine("===================================");
		Console.WriteLine();
		Console.WriteLine("The sum between the numbers is: " + sum);
		Console.WriteLine("The average of the numbers is: " + average);
	}
}
