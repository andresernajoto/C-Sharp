using System;
					
public class Program
{
	public static void Main()
	{
		
		int a, b, c, d;
		
		a = int.Parse(Console.ReadLine());
		b = int.Parse(Console.ReadLine());
		c = int.Parse(Console.ReadLine());
		d = int.Parse(Console.ReadLine());
		
		int difference = (a * b) - (c * d); // difference between a and b to c and d
		
		Console.WriteLine();
		Console.WriteLine("Difference = " + difference);
	}
}
