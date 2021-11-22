using System;
					
public class Program
{
	public static void Main()
	{
		
		string conjunto = " ";
		char[] vect = new char[10];
		int count = 0;
		
		for (int i = 0; i< vect.Length; i++) {
			vect[i] = char.Parse(Console.ReadLine());
			
			if (vect[i] != 'a' && vect[i] != 'e' && vect[i] != 'i' && vect[i] != 'o' && vect[i] != 'u') {
				count++;
				conjunto += vect[i] + " ";
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Foram encontradas " + count + " consoantes!");
		Console.WriteLine(conjunto);
		
	}
}