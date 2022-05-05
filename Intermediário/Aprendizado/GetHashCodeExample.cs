using System;
					
public class Program
{
	public static void Main()
	{
		string a = "Alex";
		string b = "Maria";
		string c = "Bob";
		string d = "Bob";
		
		// usa suas regras internas para devolver um número inteiro que representa o conteúdo da string
		Console.WriteLine(a.GetHashCode());
		Console.WriteLine(b.GetHashCode());
		Console.WriteLine(c.GetHashCode());
		Console.WriteLine(d.GetHashCode());
		
		// DICA: se o código hash gerado for diferente, os objetos são diferentes
		
	}
}