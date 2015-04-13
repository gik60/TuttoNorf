/*
 	ESERCIZIO 7
 	calcolare l'area di un trapezio
*/
using System;

namespace Exercise_19
{
	class Program
	{
		static void Main(string[] args)
		{
			int FirstBase, SecondBase, Height;
			double Area;

			Console.WriteLine("Enter the first base");				// inserimento dei dati da parte dell'utente
			FirstBase = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the second base");
			SecondBase = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the height");
			Height = Convert.ToInt32(Console.ReadLine());

			Area = 0.5*(FirstBase+SecondBase)*Height;				// calcolo l'area

			Console.WriteLine("The area of the trapezoid is {0}", Area);
		}
	}
}