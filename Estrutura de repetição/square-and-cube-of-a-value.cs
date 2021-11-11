using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Type a number: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 1; i <= number; i++) {
			int square = i * i;
			int cube = i * i * i;
			Console.WriteLine(i + " " + square + " " + cube);
		}
	}
}