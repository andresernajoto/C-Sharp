using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		
		double a, r;
		double n = 3.14159; // number of PI
		
		r = double.Parse(Console.ReadLine()); 
		
		a = n * (r * r); // formula to calculate the area
		
		Console.WriteLine("A = " + a.ToString("F4", CultureInfo.InvariantCulture));
		
	}
}
