using System;
using System.Globalization;

public class Program
{
	public static void Main()
	{
		int number;
		double workedHours, amountPerHour;
		
		Console.WriteLine("Insert your number: ");
		number = int.Parse(Console.ReadLine());
		
		System.Console.WriteLine("Insert your worked hours in the month: ");
        workedHours = double.Parse(Console.ReadLine());

		System.Console.WriteLine("Insert the amount you receive per hour: ");
        amountPerHour= double.Parse(Console.ReadLine());

        double salary = workedHours * amountPerHour;
		
		System.Console.WriteLine();
        System.Console.WriteLine("NUMBER = " + number);
        System.Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
	}
}
