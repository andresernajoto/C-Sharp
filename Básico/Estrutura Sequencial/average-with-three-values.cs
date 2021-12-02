using System;
					
public class Program
{
	public static void Main()
	{
		double a, b, c;
		
		a = double.Parse(Console.ReadLine());
		b = double.Parse(Console.ReadLine());
		c = double.Parse(Console.ReadLine());
		
		double average = (a + b + c) / 3; // formula to calculate the average
		
		Console.WriteLine();
		Console.WriteLine("MEDIA = " + average);
		
	}
}
