/*	ESERCIZIO 9
 	Stampare Hellow World tramite un oggetto e un cast.
 */
using System;

namespace Exercise_09
{
	class Program
	{
		static void Main(string[] args)
		{
			string string0 = "Hello";					// inizializza prima stringa
			string string1 = "World";					// inizializza seconda stringa

			object obj = string0 + " " + string1;		// inizializza oggetto composto dalle due stringhe più lo spazio

			string str = (string)obj;					// cast

			Console.WriteLine(str+"!");					// print

		}
	}
}
