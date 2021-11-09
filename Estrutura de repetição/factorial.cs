using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Type a number: ");
		int number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int fat = 1;

        for (int i = 1; i <= number; i++) {
			fat = fat * i;
		}
		Console.WriteLine(fat);
	}
}