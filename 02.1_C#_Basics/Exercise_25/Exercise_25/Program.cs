/*
 	ESERCIZIO 25
	dato un numero e il p-esimo inseriti dall'utente, leggere il bit in quella posizione
*/
using System;

namespace Exercise_25
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, p;
			int mask;
			int i = 1;

			Console.Write("Enter a decimal number n: ");
			n = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a position p (the first position in 0): ");
			p = Convert.ToInt32(Console.ReadLine());

			mask = i << p;	

			Console.WriteLine("The {0}th bit is {1}", p, ((n & mask) != 0 ? 1 : 0));

		}
	}
}