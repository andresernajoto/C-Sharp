using System;
					
public class Program
{
	public static void Main()
	{
		double salary, incomeTax;
		
		Console.Write("Put your salary: R$ ");
		salary = double.Parse(Console.ReadLine());
		Console.WriteLine();
		
		if (salary > 0.00 && salary <= 2000.00) {
			Console.WriteLine("Free");
		} else if (salary <= 3000) {
			/* A linha de código abaixo calcula o restante do salário isento pela taxa de 8% */
			incomeTax = 1000 * 0.08;
			Console.WriteLine("The income tax value to be paid is: R$ " + incomeTax);
		} else if (salary <= 4500) {
			/* A linha de código abaixo calcula o restante do salário que é isento, mais as dezenas pela taxa de 18% */
			incomeTax = (1000 * 0.08) + ((salary - 3000) * 0.18);
			Console.WriteLine("The income tax value to be paid is: R$ " + incomeTax);
		} else {
			/* Alinha de código abaixo calcula o restante do salário isento, mais as centenas pela taxa de 18% e as dezenas por 28% */
			incomeTax = (1000 * 0.08) + ((salary - salary +  1500) * 0.18) + ((salary - 4500) * 0.28);
			Console.WriteLine("The income tax value to be paid is: R$ " + incomeTax);
		}
	}
}
