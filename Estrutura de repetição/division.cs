using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.Write("How many numbers do you want to type: ");
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 1; i <= number; i++) {
			Console.WriteLine("Type the " + i + " value: ");
			string[] values = Console.ReadLine().Split(' ');
			Console.WriteLine();
			int value1 = int.Parse(values[0]);
			int value2 = int.Parse(values[1]);
			
			if (value2 == 0) {
				Console.WriteLine("Impossible to divide!");
				Console.WriteLine();
			} else {
				double div = (double)value1 / (double)value2;
				Console.WriteLine(div);
				Console.WriteLine();
			}
		}
	}
}