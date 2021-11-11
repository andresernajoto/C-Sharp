using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("How many integers numbers will you type? ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine();
		int countIn = 0;
		int countOut = 0;
		
		for (int i = 1; i <= number; i++) {
			Console.Write("Value " + i + ": ");
			int values = int.Parse(Console.ReadLine());
			if (values >= 10 && values <= 20) {
				countIn++;
			} else {
				countOut++;
			}
		}
		
		Console.WriteLine();
		Console.WriteLine(countIn + " in");
		Console.WriteLine(countOut + " out");
	}
}