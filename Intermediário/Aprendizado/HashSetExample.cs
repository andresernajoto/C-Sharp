using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		// instancia um HashSet
		HashSet<string> set = new HashSet<string>();
		
		// adiciona elementos do tipo string à ele
		set.Add("TV");
		set.Add("Notebook");
		set.Add("Tablet");
		
		// verifica se determinado texto está contido nele - resultado é false
		Console.WriteLine(set.Contains("Computer"));
		
		foreach (string p in set) {
			Console.WriteLine(p);
		}
	}
}