using System;
					
public class Program
{
	public static void Main()
	{
		
		double a, b;
		
		a = double.Parse(Console.ReadLine());
		b = double.Parse(Console.ReadLine());
		
		double average = (a + b) / 2; // fornmula to calculate the average
		
		Console.WriteLine();
		Console.WriteLine("MEDIA = " + average);
	}
}
