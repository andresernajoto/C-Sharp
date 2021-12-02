using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type the measures of X triangle: ");
		double mX1 = double.Parse(Console.ReadLine());
		double mX2 = double.Parse(Console.ReadLine());
		double mX3 = double.Parse(Console.ReadLine());
		Console.WriteLine();
		
		Console.WriteLine("Type the measures of Y triangle: ");
		double mY1 = double.Parse(Console.ReadLine());
		double mY2 = double.Parse(Console.ReadLine());
		double mY3 = double.Parse(Console.ReadLine());
		Console.WriteLine();
		
		double pX = (mX1 + mX2 + mX3) / 2;
		double areaX = Math.Sqrt(pX * (pX - mX1) * (pX - mX2) * (pX - mX3));
		double pY = (mY1 + mY2 + mY3) / 2;
		double areaY = Math.Sqrt(pY * (pY - mY1) * (pY - mY2) * (pY - mY3));
		
		Console.WriteLine("Area of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
		Console.WriteLine("Area of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
		Console.WriteLine();
		
		if (pX > pY) {
			Console.WriteLine("Biggest area: X");
		} else {
			Console.WriteLine("Biggest area: Y");
		}
	}
}