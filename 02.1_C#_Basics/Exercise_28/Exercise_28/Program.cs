using System;

namespace Exercise_28
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Enter an integer in the range 0 - 100:");
			int number = Convert.ToInt32 (Console.ReadLine ());

			if (number < 101 && number > 0) {

				int n_divisors = 0;

				for (int c = 1; c <= 100; c ++)
				{
					int temp = number % c;

					if (temp == 0)
						n_divisors ++;
				}
				if (n_divisors == 2)
					Console.WriteLine ("{0} is a prime number", number);
				else
					Console.WriteLine ("{0} is NOT a prime number", number);
			}
			else 
				Console.WriteLine ("{0} is not in the range 0 - 100:", number);


		}
	}
}
