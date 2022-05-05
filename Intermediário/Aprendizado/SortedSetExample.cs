using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
		SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
		
		// Union - faz a união de duas coleções
		SortedSet<int> c = new SortedSet<int>(a);
		c.UnionWith(b);
		PrintCollection(c);
		
		// Intersection - monta uma coleção com os valores presentes em duas coleções
		SortedSet<int> d = new SortedSet<int>(a);
		d.IntersectWith(b);
		PrintCollection(d);
		
		// Except - mostra os elementos da primeira coleção que não estão presentes na segunda
		SortedSet<int> e = new SortedSet<int>(a);
		e.ExceptWith(b);
		PrintCollection(e);
	}
	
	// método vazio que retorna a impressão dos valores de SortedSet
	static void PrintCollection<T>(IEnumerable<T> collection) {
		foreach (T obj in collection) {
			Console.Write(obj + " ");
		}
		
		Console.WriteLine();
	}
}