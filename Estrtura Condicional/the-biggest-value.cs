using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Put the first value: ");
		int n1 = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Put the second value: ");
		int n2 = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Put the third value: ");
		int n3 = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (n1 > n2 && n1 > n3) {
			Console.WriteLine("The biggest value is: " + n1	);
		} else if (n2 > n3) {
			Console.WriteLine("The biggest value is: " + n2);
		} else {
			Console.WriteLine("The biggest value is: " + n3);
		}
	}
}
