/*
  	ESERCIZIO 7
  	Usare una variabile BOOL per definire il sesso dell'utente
*/
using System;

namespace Exercise_07
{
	class Program
	{
		static void Main(string[] args)
		{
			char Gender;

			bool isMale = false;

			Console.WriteLine ("Gender (m/f)\n");
			Gender = Convert.ToChar (Console.ReadLine());				// Chiedo il sesso all'utente
			while (Gender != 'm' && Gender != 'f') {					// Check per vedere se il char è valido
				Console.WriteLine ("Invalid Key!\n\nGender (m/f)\n");	// Se non lo è chiedo di reinserire il sesso
				Gender = Convert.ToChar (Console.ReadLine ());
			}
			if (Gender == 'm')											// se l'utente è maschio
				isMale = true;
			else if (Gender == 'f')										// se l'utente è femmina 
				isMale = false;
			if (isMale)
				Console.WriteLine ("You are MALE.");					// stampa il sesso tramite la variabile bool
			else
				Console.WriteLine ("You are FEMALE.");
		}
	}
}
