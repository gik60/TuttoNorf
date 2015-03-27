using System;

namespace Exercise_18
{
	class Program
	{
		static void Main (string[] args)
		{
			int number;

			Console.WriteLine ("Insert a number");
			number = Convert.ToInt32 (Console.ReadLine ());

			bool bit3 = (number & 8) != 0; 

			if (bit3)
				Console.WriteLine("The third bit is 1");
			
			else
				Console.WriteLine("The third bit is 0");
			
		}
	}
}
