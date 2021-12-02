using System;
					
public class Program
{
	public static void Main()
	{
		
		int a, b, gameTime;
		
		Console.Write("Put the game start time: ");
		a = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Put the game finish time: ");
		b = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (a > b) {
			gameTime = (a - b - 24) * -1 ;
			Console.WriteLine("The game lasted " + gameTime + " hour(s)");
		} else if (a == b) {
			gameTime = 24;
			Console.WriteLine("The game lasted " + gameTime + " hour(s)");
		} else {
			gameTime = (a - b) * -1;
			Console.WriteLine("The game lasted " + gameTime + " hour(s)");
		}		
	}
}
