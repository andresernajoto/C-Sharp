using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		
		double pi = 3.14159;
		double r;
		
		r = double.Parse(Console.ReadLine());
		
		double volume = (4/3.0) * pi * (r * r * r); // formula to calculate the sphere volume
		
		
		Console.WriteLine("Volume = " + volume.ToString("F3", CultureInfo.InvariantCulture));
	}
}
