using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		
		double pi = 3.14159;
		string[] vet = Console.ReadLine().Split(' ');
		double a = double.Parse(vet[0]);
		double b = double.Parse(vet[1]);
		double c = double.Parse(vet[2]);
		
		double rectangledTriangle = (a * c) / 2; // formula to calculate the area of a rectangled triangle
		double circle = pi * (c * c); // formula to calculate the area of a circle
		double trapezium = (a + b) * c / 2; // formula to calculate the area of a trapezium
		double square = b * b; // formula to calculate the area of a square
		double retangle = a * b; // formula to calculate the area of a retangle
		
		Console.WriteLine();
		Console.WriteLine("Area of a rectangled triangle = " + rectangledTriangle.ToString("F3", CultureInfo.InvariantCulture));
		Console.WriteLine("Area of a circle = " + circle.ToString("F3", CultureInfo.InvariantCulture))		;
		Console.WriteLine("Area of a trapezium = " + trapezium.ToString("F3", CultureInfo.InvariantCulture));
		Console.WriteLine("Area of a square = " + square.ToString("F3", CultureInfo.InvariantCulture));
		Console.WriteLine("Area of a retangle = " + retangle.ToString("F3", CultureInfo.InvariantCulture));
		
	}
}
