using System;
					
public class Program
{
	public static void Main()
	{
		int n;
		
		Console.Write("Put a number: ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (n >= 0) {
			Console.WriteLine("Not negative");
		} else {
			Console.WriteLine("Negative");
		}
	}
}
