using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Put a number: ");
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		while (num > 0) {
			double squareRoot = Math.Sqrt(num);
			Console.Write("Put another number: ");
			num = int.Parse(Console.ReadLine());
			Console.WriteLine();
		}
		
		Console.WriteLine("Negative number");
	}
}
