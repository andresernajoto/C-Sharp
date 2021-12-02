using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Type the base number: ");
		int baseNum = int.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Type the expo number: ");
		int expo = int.Parse(Console.ReadLine());
		Console.WriteLine();
		int tot = 1;
		
		for (int i = 0; i < expo; i++) {
			tot = tot * baseNum;
		}
		
		Console.WriteLine(baseNum + "^" + expo + " = " + tot);
	}
}