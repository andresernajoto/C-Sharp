using System;
using System.Globalization;
					
public class Program
{
	static double Pi = 3.14;
	
	public static void Main()
	{
		// leitura do raio
		Console.Write("Entre o valor do raio: ");
		double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		
		// variável que chama a função circunferência e volume
		double circ = Circunferencia(raio);
		double vol = Volume(raio);
		
		// apresentação dos valores na tela
		Console.WriteLine();
		Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
		Console.WriteLine();
		Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
		Console.WriteLine();
		Console.WriteLine("Valor de Pi: " + Pi);
		
	}
	
	// função que calcula a circunferência
	static double Circunferencia(double r) {
		return 2.0 * Pi * r;
	}
	
	// função que calcula o volume
	static double Volume(double r) {
		return 4.0 / 3.0 * Pi * r * r * r;
	}
}