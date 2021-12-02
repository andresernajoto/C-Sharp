using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Put your username: ");
		string name = Console.ReadLine();
		Console.WriteLine();
		Console.Write("Put your password: ");
		string password = Console.ReadLine();
		
		if (password != name) {
			Console.WriteLine();
			Console.WriteLine("Hello, " + name + "!");
		} else {
			while (password == name) {
				Console.WriteLine();
				Console.WriteLine("The password can't be equal to your username. Try again");
				Console.WriteLine();
				Console.Write("Put your username: ");
				name = Console.ReadLine();
				Console.WriteLine();
				Console.Write("Put your password: ");
				password = Console.ReadLine();
			}
			
			Console.WriteLine();
			Console.WriteLine("Hello, " + name + "!");
		}
	}
}
