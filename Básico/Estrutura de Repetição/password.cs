using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Put the password: ");
		int password = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		while (password != 2002) {
			Console.Write("Invalid password. Try again: ");
			password = int.Parse(Console.ReadLine());
			Console.WriteLine();
		}
		
		Console.WriteLine("Allowed access!");
	}
}
