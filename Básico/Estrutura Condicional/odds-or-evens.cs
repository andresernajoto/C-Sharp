using System;
					
public class Program
{
	public static void Main()
	{
		int n;
		
		Console.Write("Put a number: ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (n % 2 ==0) {
			Console.WriteLine("The number is even!");
		} else {
			Console.WriteLine("The number is odd!");
		}
	}
}
