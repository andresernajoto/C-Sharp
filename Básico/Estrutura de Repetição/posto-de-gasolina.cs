using System;
					
public class Program
{
	public static void Main()
	{
		int alcool = 0 ;
		int gasolina = 0;
		int diesel = 0;
		int num = int.Parse(Console.ReadLine());
		
		while (num != 4) {
			if (num == 1) {
				// A linha abaixo soma o valor do alcool + 1
				// O mesmo acontece para a gasolina e o diesel
				alcool += 1;
				num = int.Parse(Console.ReadLine());
			} else if (num == 2){
				gasolina += 1;
				num = int.Parse(Console.ReadLine());
			} else if (num == 3) {
				diesel += 1;
				num = int.Parse(Console.ReadLine());
			} else {
				num = int.Parse(Console.ReadLine());
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Muito obrigado!");
		Console.WriteLine("Alcool = " + alcool);
		Console.WriteLine("Gasolina = " + gasolina);
		Console.WriteLine("Diesel = " + diesel);
	}
}
