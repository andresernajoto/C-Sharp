using System;
					
public class Program
{
	public static void Main()
	{
		double x, y;
		
		Console.Write("Put the X and Y values, respectively: ");
		string[] vet = Console.ReadLine().Split(' ');
		x = double.Parse(vet[0]);
		y = double.Parse(vet[1]);
		Console.WriteLine();
		
		if (x > 0 && y > 0) {
			Console.WriteLine("Q1");
		} else if (x < 0 && y >= 0) {
			Console.WriteLine("Q2");
		} else if (x < 0 && y < 0) {
			Console.WriteLine("Q3");
		} else if (x >= 0 && y < 0) {
			Console.WriteLine("Q4");
		} else {
			Console.WriteLine("Origin");
		}
		
	}
}
