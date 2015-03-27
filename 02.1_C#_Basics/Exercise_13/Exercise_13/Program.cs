/*	ESERCIZIO 13
	dichiarare una serie di variabili  in modo appropriato per tener traccia dei dati di un numero prestabilito di impiegati
*/
using System;

namespace Exercise_13
{
	class Program
	{
		static void Main(string[] args)
		{
			string FirstName, LastName;									// Nome e Cognome
			byte Age;													// Età
			char Gender;												// Sesso (un char)
			int Id;														// Identificativo numerico (compreso tra 2756000 e 27569999)

			Console.WriteLine ("Add new employee:\nName\n");			// Chiedi il nome...
			FirstName = Convert.ToString (Console.ReadLine ());			// ...e salvalo...

			Console.WriteLine ("Surname\n");							// ...il cognome...
			LastName = Convert.ToString (Console.ReadLine ());

			Console.WriteLine("Age");									// ...l'età...
			Age = Convert.ToByte (Console.ReadLine ());

			Console.WriteLine ("Gender (m/f)\n");						// ...il sesso
			Gender = Convert.ToChar (Console.ReadLine ());
			while (Gender != 'm' && Gender != 'f') {					// Check per vedere se il char è valido
				Console.WriteLine ("Invalid Key!\n\nGender (m/f)\n");	// altrimenti reiserire Gender
				Gender = Convert.ToChar (Console.ReadLine ());
			}

			Console.WriteLine ("Id\n");
			Id = Convert.ToInt32(Console.ReadLine ());
			while ( Id < 2756000 || Id > 27569999 ) {				// Check per vedere se l'Id è valido
					Console.WriteLine ("Id\n");
					Id = Convert.ToInt32 (Console.ReadLine ());
			}
			
			Console.WriteLine("Full Name: {0} {1}\nAge: {2}\nGender: {3}\nID: {4}\n", FirstName, LastName, Age, Gender, Id);
		}
	}
}