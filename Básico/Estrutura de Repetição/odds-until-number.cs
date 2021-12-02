using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Type a number: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 1; i <= number; i++) {
			if (i % 2 == 0) {
				Console.WriteLine();
			} else {
				Console.Write(i);
			}
		}
	}
}