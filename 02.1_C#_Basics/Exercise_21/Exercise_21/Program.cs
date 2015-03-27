/*
 	ESERCIZIO 21
 	calcolare e stampare il peso equivalente sulla luna del peso inserito dall'utente
*/
using System;

namespace Exercise_21
{
	class Program
	{
		static void Main(string[] args)
		{
			double EarthWeight, MoonWeigh;
			Console.Write("Enter your weight on the Earth:");		// l'utente inserisce il suo peso
			EarthWeight = Convert.ToDouble(Console.ReadLine());		// che viene salvato...
			MoonWeigh = EarthWeight * 0.17;							// ...convertito...
			Console.WriteLine("You would weight {0} kg, if you were on the moon.",MoonWeigh );	// ...e infine stampato
		}
	}
}