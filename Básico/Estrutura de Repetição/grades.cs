using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.Write("Put a grade of 0 to 10: ");
		int nota = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (nota <=0 || nota < 11) {
			Console.WriteLine("Your grade is: " + nota);
		} else {
			while (nota > 10) {
				Console.Write("Invalid grade! Put the grade again: ");
				nota = int.Parse(Console.ReadLine());
				Console.WriteLine();
			}
			
			Console.WriteLine("Your grade is: " + nota);
		}
	}
}
