/*	ESERCIZIO 3
 	salvare in variabili appropriate i seguenti numeri.
 
	le ultime cifre del DECIMAL rimangono troncate
*/
using System;

namespace Exercise_03{
	class Program
	{
		static void Main(string[] args)
		{
			// Variables
			float n0 = 5.0f;
			float n1 = -5.01f;
			double n2 = 34.567839023d;
			float n3 = 12.345f;
			double n4 = 8923.1234857d;
			decimal n5 = 3456.091124875956542151256683467M;


			Console.WriteLine("{0}, that should be 5, is a FLOAT", n0);

			Console.WriteLine("{0}, that should be -5.01, is a FLOAT.", n1);

			Console.WriteLine("{0}, that should be 34.567839023, is a DOUBLE.", n2);

			Console.WriteLine("{0}, that should be 12.345, is a FLOAT.", n3);

			Console.WriteLine("{0}, that should be 8923.1234857, is a DOUBLE.", n4);

			Console.WriteLine("{0}, that should be 3456.091124875956542151256683467, is a DECIMAL.", n5);

		}
	}
}