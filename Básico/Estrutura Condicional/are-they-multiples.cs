using System;
					
public class Program
{
	public static void Main()
	{
		
		int a, b;
		
		Console.Write("Put the value for A: ");
		a = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Put the value for B: ");
		b = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (a % b == 0 || b % a == 0) {
			Console.WriteLine("The numbers are multiple");
		} else {
			Console.WriteLine("The numbers are not multiple");
		}
	}
}
