using System;
					
public class Program
{
	public static void Main()
	{
		int numberOut = 0;
		int numberIn = 0;
		for (int i = 0; i < 10; i++) {
			int num = int.Parse(Console.ReadLine());
			if (num % 2 == 0) {
				numberOut += 1;
			} else {
				numberIn += 1;
			}
		}
		
		Console.WriteLine();
		Console.WriteLine(numberOut + " evens numbers");
		Console.WriteLine(numberIn + " odds numbers");
	}
}