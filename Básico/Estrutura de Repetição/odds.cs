using System;
					
public class Program
{
	public static void Main()
	{
		int count = 0;
		
		while (count < 50) {
			count += 1;
			if (count % 2 == 0) {
				Console.WriteLine();
			} else {
				Console.WriteLine(count);
			}
		}
	}
}
