/*
 	ESERCIZIO 17
 	la terza cifra da destra di un numero di almeno tre cifre inserito dall'utente è un 7?
*/
using System;

namespace Exercise_17
{
		class Program
		{
			static void Main(string[] args)
			{
			int n;
			Console.WriteLine ("Enter a Number composed, at least, by three digits.");			// inserimente di un numero
			n = Convert.ToInt32 (Console.ReadLine());											// converto e salvo

			bool Is7 = (((n / 100) % 10) == 7);													// confronto la terza cifra con 7

			if (Is7)																			// stampo il risultato del confronto
				Console.WriteLine("Reading from right to left, the third digit is 7.");
			else 
				Console.WriteLine ("Reading from right to left, the third digit is not 7.");

			}
		}
	}