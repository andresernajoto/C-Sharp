using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		// lista das unidades de medidas que podem ser utilizadas
		Console.WriteLine("Segue abaixo a lista de unidades de medida de comprimento que podem ser calculadas!");
		Console.WriteLine("m - Metro");
		Console.WriteLine("dm - Decímetro");
		Console.WriteLine("cm - Centímetro");
		Console.WriteLine("mm - Milímetro");
		Console.WriteLine();
		
		// leitura da unidade de medida de entrada
		Console.Write("Insira a unidade de medida que deseja calcular: ");
		string unidade = Console.ReadLine();
		Console.WriteLine();
		Console.WriteLine("=====================================================================");
		Console.WriteLine();
		
		// leitura da altura do produto escolhido
		Console.Write("Insira a altura a ser calculada (utilize o ponto em caso decimal): ");
		double altura = double.Parse(Console.ReadLine());
		Console.WriteLine();
		// leitura do comprimento do produto escolhido
		Console.Write("Insira o comprimento a ser calculado (utilize o ponto em caso decimal): ");
		double comprimento = double.Parse(Console.ReadLine());
		Console.WriteLine();
		
		// calculo da area com os valores da altura e comprimento inseridos
		double area = altura * comprimento;
		Console.WriteLine("==========================================================================================");
		Console.WriteLine();
		
		// leitura da unidade de medida de saída
		Console.Write("Escolha a unidade de saída da área calculada, usando os mesmo parâmetros da lista do topo: ");
		string unidadeSaida = Console.ReadLine();
		Console.WriteLine();
		
		/* condicionamento permite realizar as
		conversões entre as unidades de medida
		e apresenta o valor final convertido*/
		if (unidade == "m" && unidadeSaida == "dm" || unidade == "dm" && unidadeSaida == "cm" || unidade == "cm" && unidadeSaida == "mm") {
			area *= 10;
			Console.WriteLine("O resultado da área de " + unidade + " para " + unidadeSaida + " é: " + area.ToString("F4", CultureInfo.InvariantCulture) + unidadeSaida);
		} else if (unidade == "m" && unidadeSaida == "cm" || unidade == "dm" && unidadeSaida == "mm") {
			area *= 100;
			Console.WriteLine("O resultado da área de " + unidade + " para " + unidadeSaida + " é: " + area.ToString("F4", CultureInfo.InvariantCulture) + unidadeSaida);
		}	else if (unidade == "m" && unidadeSaida == "mm") {
			area *= 1000;
			Console.WriteLine("O resultado da área de " + unidade + " para " + unidadeSaida + " é: " + area.ToString("F4", CultureInfo.InvariantCulture) + unidadeSaida);
		} else if (unidade == "mm" && unidadeSaida == "cm" || unidade == "cm" && unidadeSaida == "dm" || unidade == "dm" && unidadeSaida == "m") {
			area /= 10;
			Console.WriteLine("O resultado da área de " + unidade + " para " + unidadeSaida + " é: " + area.ToString("F4", CultureInfo.InvariantCulture) + unidadeSaida);
		} else if (unidade == "mm" && unidadeSaida == "dm" || unidade == "cm" && unidadeSaida == "m") {
			area /= 100;
			Console.WriteLine("O resultado da área de " + unidade + " para " + unidadeSaida + " é: " + area.ToString("F4", CultureInfo.InvariantCulture) + unidadeSaida);
		}	else if (unidade == "mm" && unidadeSaida == "m") {
			area /= 1000;
			Console.WriteLine("O resultado da área de " + unidade + " para " + unidadeSaida + " é: " + area.ToString("F4", CultureInfo.InvariantCulture) + unidadeSaida);
		}
	}
}