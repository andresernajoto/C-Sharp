using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Put a number: ");
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine();
		int count = 0;
		int sum;
		Console.WriteLine();
		
		if (num <= 10) {
			while (count < 10) {
				count += 1;
				sum = num * count;
				Console.WriteLine(num + " X " + count + " = " + sum);
			}
		} else {
			Console.WriteLine("Maximum number reached! Try again and put a number of 0 to 10.");
		}
	}
}
