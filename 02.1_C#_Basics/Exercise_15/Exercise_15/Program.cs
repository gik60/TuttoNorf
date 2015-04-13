/*
	ESERCIZIO 15
	Chiedere all'utente un numero e calcolare se è pari o dispari
*/

using System;

namespace Exercise_15
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			bool odd;
			Console.WriteLine("Enter a number:");				// Chiedo all'utente un numero
			n = Convert.ToInt32(Console.ReadLine());			// Lo converto e lo salvo
			odd = n % 2 == 1;   								// odd = true => n % 2 = 1
																// odd = false => n % 2 != 1
			if (odd)											// stampa se il numero è pari o dispari
			{
				Console.WriteLine("{0} is an odd number.",n);
			}   
			else
			{
				Console.WriteLine("{0} is an even number.",n);
			}
		}
	}
}