using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine("Choose a code from the list below to get your lunch");
		Console.WriteLine("1 - Hot Dog");
		Console.WriteLine("2 - X-Salad");
		Console.WriteLine("3 - X-Bacon");
		Console.WriteLine("4 - Simples Toast");
		Console.WriteLine("5 - Soda");
		Console.WriteLine();
		
		double hotDog = 4.00; 
		double xSalad = 4.50;
		double xBacon = 5.00;
		double simpleToast = 2.00;
		double soda = 1.50;
		double totalValue;	
		int code, quantity;
		
		Console.Write("Put the code and the quantity on same line: ");
		string[] vet = Console.ReadLine().Split(' ');
		code = int.Parse(vet[0]);
		quantity = int.Parse(vet[1]);
		Console.WriteLine();
		
		
		if (code == 1) {
			totalValue = hotDog * (double)quantity;
			Console.WriteLine("Total = R$ " + totalValue);
		} else if (code == 2) {
			totalValue = xSalad * (double)quantity;
			Console.WriteLine("Total = R$ " + totalValue);
		} else if (code == 3) {
			totalValue = xBacon * (double)quantity; 
			Console.WriteLine("Total =  R$ " + totalValue);
		} else if (code == 4) {
			totalValue = simpleToast * (double)quantity;
			Console.WriteLine("Total = R$" + totalValue); 
		} else if (code == 5) {
			totalValue = soda * (double)quantity;
			Console.WriteLine("Total = R$ " + totalValue);
		} else if (code == 0 || code >= 6) {
			Console.WriteLine("This lunch doesn't exist on our menu!");
		}
	}
}
