using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Put a value to X and Y: ");
		string[] values = Console.ReadLine().Split(' ');
		int x = int.Parse(values[0]);
		int y = int.Parse(values[1]);
		
		while (x != 0 && y != 0) {
			if (x > 0 && y > 0) {
				Console.WriteLine("First quadrant");
			} else if (x < 0 && y > 0) {
				Console.WriteLine("Second quadrant");
			} else if (x < 0 && y < 0) {
				Console.WriteLine("Third quadrant");
			} else {
				Console.WriteLine("Fourth quadrant");
			}
			
			Console.WriteLine();
			values = Console.ReadLine().Split(' ');
			x = int.Parse(values[0]);
			y = int.Parse(values[1]);
			Console.WriteLine();
		}
	}
}
