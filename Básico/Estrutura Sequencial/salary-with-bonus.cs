using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		
		String sellerName;
		double salary, sale;
		
		sellerName = Console.ReadLine();
		salary = double.Parse(Console.ReadLine());
		sale = double.Parse(Console.ReadLine());
		
		double finalSalary = (sale * 0.15) + salary; // 0.15 = 15%
		
		Console.WriteLine();
		Console.WriteLine("Total = $ " + finalSalary.ToString("F2", CultureInfo.InvariantCulture));
		
	}
}
